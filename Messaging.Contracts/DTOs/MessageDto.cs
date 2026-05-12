namespace Messaging.Contracts.DTOs;

public record MessageDto(
    Guid Id,
    string SenderEmail,
    string RecipientEmail,
    string Subject,
    string Body,
    int SizeBytes,
    DateTime SentAt
);