namespace Messaging.Domain;
 
public class Message
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string SenderEmail { get; set; } = string.Empty;
    public string RecipientEmail { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public int SizeBytes { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}