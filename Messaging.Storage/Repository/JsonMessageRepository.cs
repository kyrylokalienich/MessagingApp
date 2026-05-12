using System.Text.Json;
using Messaging.Contracts.Repository;
using Messaging.Domain;

namespace Messaging.Storage;

/// <summary>
/// Сховище повідомлень на основі JSON-файлу.
/// Реалізує патерн Repository — деталі зберігання ізольовані від бізнес-логіки.
/// </summary>
public class JsonMessageRepository : IMessageRepository
{
    private readonly string _filePath;
    private List<Message> _messages;
    private static readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

    public JsonMessageRepository(string dataDirectory = "data")
    {
        Directory.CreateDirectory(dataDirectory);
        _filePath = Path.Combine(dataDirectory, "messages.json");
        _messages = Load();
    }

    public void Add(Message message)
    {
        _messages.Add(message);
    }

    public IReadOnlyList<Message> GetAll() => _messages.AsReadOnly();

    public void Save()
    {
        var json = JsonSerializer.Serialize(_messages, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    private List<Message> Load()
    {
        if (!File.Exists(_filePath)) return new List<Message>();
        try
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Message>>(json) ?? new List<Message>();
        }
        catch
        {
            return new List<Message>();
        }
    }
}