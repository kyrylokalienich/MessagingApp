using Messaging.Contracts.DTOs;
using Messaging.Contracts.Repository;
using Messaging.Contracts.Services;
using Messaging.Domain;
using Messaging.Auth;

namespace Messaging.Services;

/// <summary>
/// Компонент аутентифікації.
/// Відповідає за реєстрацію користувачів, перевірку облікових даних
/// та формування email у форматі login@messaging.local.
/// Безпека: паролі ніколи не зберігаються у відкритому вигляді.
/// </summary>
public class AuthService : IAuthService
{
    private readonly IUserRepository userRepo;

    public AuthService(IUserRepository userRepository)
    {
        userRepo = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    public UserDto Register(RegisterRequest request)
    {
        ValidateRegisterRequest(request);

        if (userRepo.LoginExists(request.Login))
            throw new InvalidOperationException($"Логін '{request.Login}' вже зайнятий.");

        var (hash, salt) = PasswordHasher.Hash(request.Password);

        var user = new User
        {
            Login = request.Login.Trim(),
            Email = BuildEmail(request.Login),
            PasswordHash = hash,
            PasswordSalt = salt,
            CreatedAt = DateTime.UtcNow
        };

        userRepo.Add(user);
        userRepo.Save();

        return ToDto(user);
    }

    public UserDto Login(LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Login))
            throw new ArgumentException("Логін не може бути порожнім.");
        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("Пароль не може бути порожнім.");

        var user = userRepo.FindByLogin(request.Login.Trim())
            ?? throw new UnauthorizedAccessException("Невірний логін або пароль.");

        if (!PasswordHasher.Verify(request.Password, user.PasswordHash, user.PasswordSalt))
            throw new UnauthorizedAccessException("Невірний логін або пароль.");

        return ToDto(user);
    }

    public bool LoginExists(string login) => userRepo.LoginExists(login);

    // Email формується автоматично згідно з вимогою завдання
    private static string BuildEmail(string login) => $"{login.Trim().ToLowerInvariant()}@messaging.local";

    private static void ValidateRegisterRequest(RegisterRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Login))
            throw new ArgumentException("Логін не може бути порожнім.");
        if (request.Login.Length < 3 || request.Login.Length > 50)
            throw new ArgumentException("Логін повинен містити від 3 до 50 символів.");
        if (!System.Text.RegularExpressions.Regex.IsMatch(request.Login, @"^[a-zA-Z0-9_.-]+$"))
            throw new ArgumentException("Логін може містити лише літери, цифри, '_', '.' та '-'.");
        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("Пароль не може бути порожнім.");
        if (request.Password.Length < 6)
            throw new ArgumentException("Пароль повинен містити щонайменше 6 символів.");
    }

    private static UserDto ToDto(User user) => new(user.Id, user.Login, user.Email);
}