// ReSharper disable once CheckNamespace
namespace Messaging.Contracts.DTOs;

public record MessageGroupDto(
    string GroupLabel,
    IReadOnlyList<MessageDto> Messages
);