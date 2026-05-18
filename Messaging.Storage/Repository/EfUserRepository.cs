using Messaging.Contracts.Repository;
using Messaging.Domain;
using Microsoft.EntityFrameworkCore;

namespace Messaging.Storage;

public class EfUserRepository : IUserRepository
{
    private readonly MessagingDbContext _context;

    public EfUserRepository(MessagingDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Add(User user) => _context.Users.Add(user);

    public User? FindByLogin(string login) =>
        _context.Users.AsNoTracking()
            .FirstOrDefault(u => EF.Functions.ILike(u.Login, login));

    public User? FindByEmail(string email) =>
        _context.Users.AsNoTracking()
            .FirstOrDefault(u => EF.Functions.ILike(u.Email, email));

    public bool LoginExists(string login) =>
        _context.Users.Any(u => EF.Functions.ILike(u.Login, login));

    public void Save() => _context.SaveChanges();
}
