namespace Messaging.Contracts.DTOs;

public record UserDto(
    int Id,
    string Login,
    string Email
);
