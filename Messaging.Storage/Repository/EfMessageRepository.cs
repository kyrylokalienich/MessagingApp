using Messaging.Contracts.Repository;
using Messaging.Domain;
using Microsoft.EntityFrameworkCore;

namespace Messaging.Storage;

public class EfMessageRepository : IMessageRepository
{
    private readonly MessagingDbContext _context;

    public EfMessageRepository(MessagingDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Add(Message message) => _context.Messages.Add(message);

    public Message? GetById(int id) =>
        _context.Messages
            .Include(m => m.Sender)
            .Include(m => m.Recipient)
            .FirstOrDefault(m => m.Id == id);

    public IReadOnlyList<Message> GetAll() =>
        _context.Messages
            .AsNoTracking()
            .Include(m => m.Sender)
            .Include(m => m.Recipient)
            .ToList();

    public void Save()
    {
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
}
