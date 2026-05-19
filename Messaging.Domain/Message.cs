namespace Messaging.Domain;

public class Message
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public int RecipientId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string? Body { get; set; }
    public DateTime SentAt { get; set; }
    public int SizeBytes { get; set; }
    public bool IsDeletedBySender { get; set; }
    public bool IsDeletedByRecipient { get; set; }

    public User Sender { get; set; } = null!;
    public User Recipient { get; set; } = null!;
}
