namespace Messaging.Contracts.DTOs;

public record MessageDto(
    int Id,
    string SenderEmail,
    string RecipientEmail,
    string Subject,
    string Body,
    int SizeBytes,
    DateTime SentAt
);
