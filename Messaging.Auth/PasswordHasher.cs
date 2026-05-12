using System.Security.Cryptography;
using System.Text;

namespace Messaging.Auth;

/// <summary>
/// Хешування паролів.
/// Використовує SHA-256 із випадковою сіллю (salt) для кожного пароля.
/// </summary>
public static class PasswordHasher
{
    private const int SaltSize = 32;

    public static (string hash, string salt) Hash(string password)
    {
        var saltBytes = RandomNumberGenerator.GetBytes(SaltSize);
        var salt = Convert.ToBase64String(saltBytes);
        var hash = ComputeHash(password, salt);
        return (hash, salt);
    }

    public static bool Verify(string password, string hash, string salt)
    {
        var computed = ComputeHash(password, salt);
        // Порівняння з константним часом — захист від timing attacks
        return CryptographicOperations.FixedTimeEquals(
            Encoding.UTF8.GetBytes(computed),
            Encoding.UTF8.GetBytes(hash));
    }

    private static string ComputeHash(string password, string salt)
    {
        var input = Encoding.UTF8.GetBytes(password + salt);
        var hashBytes = SHA256.HashData(input);
        return Convert.ToBase64String(hashBytes);
    }
}