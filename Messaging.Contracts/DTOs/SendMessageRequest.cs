namespace Messaging.Contracts.DTOs;

public record SendMessageRequest(
    string RecipientEmail,
    string Subject,
    string Body
);