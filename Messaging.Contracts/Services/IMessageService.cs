using Messaging.Contracts.DTOs;

namespace Messaging.Contracts.Interfaces;

/// <summary>
/// Компонент бізнес-логіки повідомлень.
/// Надає функції відправлення, перегляду, пошуку та групування повідомлень.
/// </summary>
public interface IMessageService
{
    MessageDto Send(string senderEmail, SendMessageRequest request);

    IReadOnlyList<MessageDto> GetSent(string senderEmail, bool ascending = false);

    IReadOnlyList<MessageDto> GetInbox(string recipientEmail, bool ascending = false);

    IReadOnlyList<MessageDto> Search(string userEmail, string query);

    IReadOnlyList<MessageDto> GetByDateRange(string userEmail, DateTime from, DateTime to);

    IReadOnlyList<MessageGroupDto> GetSentGrouped(string senderEmail);

    IReadOnlyList<MessageGroupDto> GetInboxGrouped(string recipientEmail);
}


// <summary>