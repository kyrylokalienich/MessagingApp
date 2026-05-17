using Messaging.Contracts.DTOs;
using Messaging.Contracts.Services;
using Messaging.Services;
using Messaging.Storage;

namespace MessagingAppForms;

public sealed class AppSession
{
    public IAuthService AuthService { get; }
    public IMessageService MessageService { get; }
    public UserDto? CurrentUser { get; set; }

    public static AppSession Instance { get; } = new();

    private AppSession()
    {
        var userRepo = new JsonUserRepository("data");
        var messageRepo = new JsonMessageRepository("data");
        AuthService = new AuthService(userRepo);
        MessageService = new MessageService(messageRepo);
    }
}
