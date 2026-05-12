using System.Text.Json;
using Messaging.Contracts.Repository;
using Messaging.Domain;

namespace Messaging.Storage;

/// <summary>
/// Сховище користувачів на основі JSON-файлу.
/// Паролі зберігаються виключно у вигляді хешів — відкриті паролі не зберігаються.
/// </summary>
public class JsonUserRepository : IUserRepository
{
    private readonly string _filePath;
    private List<User> _users;
    private static readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

    public JsonUserRepository(string dataDirectory = "data")
    {
        Directory.CreateDirectory(dataDirectory);
        _filePath = Path.Combine(dataDirectory, "users.json");
        _users = Load();
    }

    public void Add(User user) => _users.Add(user);

    public User? FindByLogin(string login) =>
        _users.FirstOrDefault(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase));

    public User? FindByEmail(string email) =>
        _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

    public bool LoginExists(string login) =>
        _users.Any(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase));

    public void Save()
    {
        var json = JsonSerializer.Serialize(_users, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    private List<User> Load()
    {
        if (!File.Exists(_filePath)) return new List<User>();
        try
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
        catch
        {
            return new List<User>();
        }
    }
}