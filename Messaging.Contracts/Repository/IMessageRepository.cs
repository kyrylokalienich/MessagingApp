using Messaging.Domain;

namespace Messaging.Contracts.Repository;

public interface IMessageRepository
{
    void Add(Message message);
    Message? GetById(int id);
    IReadOnlyList<Message> GetAll();
    void Save();
}