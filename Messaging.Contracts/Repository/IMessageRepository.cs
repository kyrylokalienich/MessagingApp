using Messaging.Domain;

namespace Messaging.Contracts.Repository;

public interface IMessageRepository
{
    void Add(Message message);
    IReadOnlyList<Message> GetAll();
    void Save();
}

public interface IUserRepository
{
    void Add(User user);
    User? FindByLogin(string login);
    User? FindByEmail(string email);
    bool LoginExists(string login);
    void Save();
}
