using Messaging.Domain;

namespace Messaging.Contracts.Repository;

public interface IMessageRepository
{
    void Add(Message message);
    IReadOnlyList<Message> GetAll();
    void Save();
}