namespace Messaging.Contracts.DTOs;

public record RegisterRequest(
    string Login,
    string Password
);