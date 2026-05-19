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
        MessagingStorageBootstrap.ApplyMigrations();
        var (userRepo, messageRepo) = MessagingStorageBootstrap.CreateRepositories();
        AuthService = new AuthService(userRepo);
        MessageService = new MessageService(messageRepo, userRepo);
    }
}
