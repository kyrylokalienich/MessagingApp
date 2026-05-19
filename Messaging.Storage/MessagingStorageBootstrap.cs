using Microsoft.EntityFrameworkCore;

namespace Messaging.Storage;

public static class MessagingStorageBootstrap
{
    public static DbContextOptions<MessagingDbContext> CreateOptions() =>
        new DbContextOptionsBuilder<MessagingDbContext>()
            .UseNpgsql(DatabaseOptions.ConnectionString)
            .Options;

    public static MessagingDbContext CreateContext() => new(CreateOptions());

    public static void ApplyMigrations()
    {
        using var context = CreateContext();
        context.Database.Migrate();
    }

    public static (EfUserRepository UserRepository, EfMessageRepository MessageRepository) CreateRepositories()
    {
        var context = CreateContext();
        return (new EfUserRepository(context), new EfMessageRepository(context));
    }
}
