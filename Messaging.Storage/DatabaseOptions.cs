namespace Messaging.Storage;

public static class DatabaseOptions
{
    public const string DefaultConnectionString =
        "Host=localhost;Port=5432;Database=messagingapp;Username=postgres;Password=postgres";

    public static string ConnectionString =>
        Environment.GetEnvironmentVariable("MESSAGING_DB_CONNECTION") ?? DefaultConnectionString;
}
