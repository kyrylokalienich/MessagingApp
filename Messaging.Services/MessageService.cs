using Messaging.Contracts.DTOs;
using Messaging.Contracts.Repository;
using Messaging.Contracts.Services;
using Messaging.Domain;

namespace Messaging.Services;

/// <summary>
/// Компонент бізнес-логіки повідомлень.
/// Реалізує всі операції: відправлення, перегляд вхідних/надісланих,
/// пошук, фільтрацію за датою та групування за часовими проміжками.
/// Дата та час відправлення встановлюються системою автоматично.
/// </summary>
public class MessageService : IMessageService
{
    private readonly IMessageRepository repo;

    public MessageService(IMessageRepository messageRepository)
    {
        repo = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));
    }

    public MessageDto Send(string senderEmail, SendMessageRequest request)
    {
        ValidateSendRequest(senderEmail, request);

        var body = request.Body ?? string.Empty;
        var sizeBytes = System.Text.Encoding.UTF8.GetByteCount(body);

        var message = new Message
        {
            SenderEmail = senderEmail.Trim().ToLowerInvariant(),
            RecipientEmail = request.RecipientEmail.Trim().ToLowerInvariant(),
            Subject = request.Subject.Trim(),
            Body = body,
            SizeBytes = sizeBytes,
            SentAt = DateTime.UtcNow   // Час відправлення встановлюється системою
        };

        repo.Add(message);
        repo.Save();
        return ToDto(message);
    }

    public IReadOnlyList<MessageDto> GetSent(string senderEmail, bool ascending = false)
    {
        var email = senderEmail.ToLowerInvariant();
        var msgs = repo.GetAll()
            .Where(m => m.SenderEmail == email && !m.IsDeleted);
        return Sort(msgs, ascending).Select(ToDto).ToList();
    }

    public IReadOnlyList<MessageDto> GetInbox(string recipientEmail, bool ascending = false)
    {
        var email = recipientEmail.ToLowerInvariant();
        var msgs = repo.GetAll()
            .Where(m => m.RecipientEmail == email && !m.IsDeleted);
        return Sort(msgs, ascending).Select(ToDto).ToList();
    }

    public IReadOnlyList<MessageDto> Search(string userEmail, string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return Array.Empty<MessageDto>();

        var email = userEmail.ToLowerInvariant();
        var q = query.Trim().ToLowerInvariant();

        return repo.GetAll()
            .Where(m => !m.IsDeleted &&
                        (m.SenderEmail == email || m.RecipientEmail == email) &&
                        (m.Subject.ToLowerInvariant().Contains(q) ||
                         m.Body.ToLowerInvariant().Contains(q) ||
                         m.SenderEmail.Contains(q) ||
                         m.RecipientEmail.Contains(q)))
            .OrderByDescending(m => m.SentAt)
            .Select(ToDto)
            .ToList();
    }

    public IReadOnlyList<MessageDto> GetByDateRange(string userEmail, DateTime from, DateTime to)
    {
        if (from > to) throw new ArgumentException("Початкова дата не може бути пізніше кінцевої.");

        var email = userEmail.ToLowerInvariant();
        var toEnd = to.Date.AddDays(1).AddTicks(-1); // Включити весь день "to"

        return repo.GetAll()
            .Where(m => !m.IsDeleted &&
                        (m.SenderEmail == email || m.RecipientEmail == email) &&
                        m.SentAt >= from && m.SentAt <= toEnd)
            .OrderByDescending(m => m.SentAt)
            .Select(ToDto)
            .ToList();
    }

    public IReadOnlyList<MessageGroupDto> GetSentGrouped(string senderEmail)
    {
        var messages = GetSent(senderEmail, ascending: false);
        return GroupByTimeRange(messages);
    }

    public IReadOnlyList<MessageGroupDto> GetInboxGrouped(string recipientEmail)
    {
        var messages = GetInbox(recipientEmail, ascending: false);
        return GroupByTimeRange(messages);
    }

    // Групування повідомлень за часовими проміжками
    private static IReadOnlyList<MessageGroupDto> GroupByTimeRange(IReadOnlyList<MessageDto> messages)
    {
        var now = DateTime.UtcNow;
        var groups = new[]
        {
            ("Сьогодні",        (Func<DateTime, bool>)(d => d.Date == now.Date)),
            ("Вчора",           d => d.Date == now.Date.AddDays(-1)),
            ("Цей тиждень",     d => d >= now.Date.AddDays(-(int)now.DayOfWeek) && d.Date < now.Date.AddDays(-1)),
            ("Цей місяць",      d => d.Month == now.Month && d.Year == now.Year && d < now.Date.AddDays(-(int)now.DayOfWeek)),
            ("Цей рік",         d => d.Year == now.Year && d.Month < now.Month),
            ("Більше року тому",d => d.Year < now.Year)
        };

        var result = new List<MessageGroupDto>();
        var assigned = new HashSet<Guid>();

        foreach (var (label, predicate) in groups)
        {
            var group = messages
                .Where(m => !assigned.Contains(m.Id) && predicate(m.SentAt))
                .ToList();

            if (group.Count > 0)
            {
                foreach (var m in group) assigned.Add(m.Id);
                result.Add(new MessageGroupDto(label, group));
            }
        }

        // Решта (якщо не потрапила в жодну групу)
        var rest = messages.Where(m => !assigned.Contains(m.Id)).ToList();
        if (rest.Count > 0)
            result.Add(new MessageGroupDto("Інше", rest));

        return result;
    }

    private static IEnumerable<Message> Sort(IEnumerable<Message> messages, bool ascending) =>
        ascending
            ? messages.OrderBy(m => m.SentAt)
            : messages.OrderByDescending(m => m.SentAt);

    private static void ValidateSendRequest(string senderEmail, SendMessageRequest request)
    {
        if (string.IsNullOrWhiteSpace(senderEmail))
            throw new ArgumentException("Email відправника порожній.");
        if (string.IsNullOrWhiteSpace(request.RecipientEmail))
            throw new ArgumentException("Email отримувача не може бути порожнім.");
        if (!IsValidEmail(request.RecipientEmail))
            throw new ArgumentException("Невірний формат email отримувача.");
        if (string.IsNullOrWhiteSpace(request.Subject))
            throw new ArgumentException("Тема повідомлення не може бути порожньою.");
        if (request.Subject.Length > 200)
            throw new ArgumentException("Тема не може перевищувати 200 символів.");
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email.Trim().ToLowerInvariant() || true;
        }
        catch { return false; }
    }

    private static MessageDto ToDto(Message m) =>
        new(m.Id, m.SenderEmail, m.RecipientEmail, m.Subject, m.Body, m.SizeBytes, m.SentAt);
}