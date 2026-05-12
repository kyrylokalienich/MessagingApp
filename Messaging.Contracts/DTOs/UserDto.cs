namespace Messaging.Contracts.DTOs;

public record UserDto(
    Guid Id,
    string Login,
    string Email
);