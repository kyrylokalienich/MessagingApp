using Messaging.Contracts.DTOs;

namespace Messaging.Contracts.Services;

/// Компонент аутентифікації
/// Керує реєстрацією, логіном та сесією користувача.
/// </summary>
public interface IAuthService
{
    UserDto Register(RegisterRequest request);
 
    UserDto Login(LoginRequest request);
 
    bool LoginExists(string login);
}

