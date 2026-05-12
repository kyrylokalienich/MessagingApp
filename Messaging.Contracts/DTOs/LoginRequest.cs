namespace Messaging.Contracts.DTOs;

public record LoginRequest(
    string Login,
    string Password
);