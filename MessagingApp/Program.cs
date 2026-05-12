using Messaging.Contracts.DTOs;
using Messaging.Services;
using Messaging.Storage;

var userRepo = new JsonUserRepository("data");
var messageRepo = new JsonMessageRepository("data");
var authService = new AuthService(userRepo);
var messageService = new MessageService(messageRepo);

UserDto? currentUser = null;

Console.WriteLine("=== MessagingApp CLI ===");

while (true)
{
    if (currentUser is null)
    {
        Console.WriteLine();
        Console.WriteLine("1. Зареєструватися");
        Console.WriteLine("2. Увiйти");
        Console.WriteLine("0. Вихiд");
        Console.Write("Оберiть дiю: ");
        var input = Console.ReadLine()?.Trim();

        if (input == "1")
            Register();
        else if (input == "2")
            Login();
        else if (input == "0")
            break;
        else
            Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Ви увiйшли як: {currentUser.Login} ({currentUser.Email})");
        Console.WriteLine("1. Надiслати повiдомлення");
        Console.WriteLine("2. Переглянути надiсланi повiдомлення");
        Console.WriteLine("3. Переглянути вхiднi повiдомлення");
        Console.WriteLine("4. Переглянути надiсланi повiдомлення, згрупованi за часом");
        Console.WriteLine("5. Переглянути вхiднi повiдомлення, згрупованi за часом");
        Console.WriteLine("6. Пошук повiдомлень");
        Console.WriteLine("7. Фiльтрацiя повiдомлень за датою");
        Console.WriteLine("8. Вийти з облiкового запису");
        Console.WriteLine("0. Вихiд");
        Console.Write("Оберiть дiю: ");
        var input = Console.ReadLine()?.Trim();

        if (input == "1")
            SendMessage();
        else if (input == "2")
            ShowMessages(messageService.GetSent(currentUser.Email, ChooseSortOrder()), "Надiсланi повiдомлення");
        else if (input == "3")
            ShowMessages(messageService.GetInbox(currentUser.Email, ChooseSortOrder()), "Вхiднi повiдомлення");
        else if (input == "4")
            ShowGrouped(messageService.GetSentGrouped(currentUser.Email), "Надiсланi повiдомлення, згрупованi за часом");
        else if (input == "5")
            ShowGrouped(messageService.GetInboxGrouped(currentUser.Email), "Вхiднi повiдомлення, згрупованi за часом");
        else if (input == "6")
            SearchMessages();
        else if (input == "7")
            FilterByDateRange();
        else if (input == "8")
        {
            currentUser = null;
            Console.WriteLine("Ви вийшли з облiкового запису.");
        }
        else if (input == "0")
            break;
        else
            Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
    }
}

Console.WriteLine("Дякуємо за використання MessagingApp. До побачення!");

void Register()
{
    Console.WriteLine();
    Console.WriteLine("=== Реєстрацiя ===");
    Console.Write("Логiн: ");
    var login = Console.ReadLine()?.Trim() ?? string.Empty;
    Console.Write("Пароль: ");
    var password = ReadPassword();

    try
    {
        var user = authService.Register(new RegisterRequest(login, password));
        Console.WriteLine($"Реєстрацiю виконано успiшно. Ваш email: {user.Email}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка реєстрацiї: {ex.Message}");
    }
}

void Login()
{
    Console.WriteLine();
    Console.WriteLine("=== Вхiд ===");
    Console.Write("Логiн: ");
    var login = Console.ReadLine()?.Trim() ?? string.Empty;
    Console.Write("Пароль: ");
    var password = ReadPassword();

    try
    {
        currentUser = authService.Login(new LoginRequest(login, password));
        Console.WriteLine($"Вхiд успiшний. Привiт, {currentUser.Login}!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не вдалося виконати вхiд: {ex.Message}");
        currentUser = null;
    }
}

void SendMessage()
{
    Console.WriteLine();
    Console.WriteLine("=== Надiслати повiдомлення ===");
    Console.Write("Email отримувача: ");
    var recipient = Console.ReadLine()?.Trim() ?? string.Empty;
    Console.Write("Тема: ");
    var subject = Console.ReadLine()?.Trim() ?? string.Empty;
    Console.WriteLine("Текст повiдомлення (натиснiть Enter для завершення):");
    var body = Console.ReadLine() ?? string.Empty;

    try
    {
        var message = messageService.Send(currentUser!.Email, new SendMessageRequest(recipient, subject, body));
        Console.WriteLine($"Повiдомлення надiслано. Розмiр: {message.SizeBytes} байт, Дата: {message.SentAt:u}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не вдалося надiслати повiдомлення: {ex.Message}");
    }
}

void ShowMessages(IReadOnlyList<MessageDto> messages, string header)
{
    Console.WriteLine();
    Console.WriteLine($"=== {header} ===");

    if (!messages.Any())
    {
        Console.WriteLine("Повiдомлень немає.");
        return;
    }

    foreach (var message in messages)
    {
        PrintMessage(message);
    }
}

void ShowGrouped(IReadOnlyList<MessageGroupDto> groups, string header)
{
    Console.WriteLine();
    Console.WriteLine($"=== {header} ===");

    if (!groups.Any())
    {
        Console.WriteLine("Повiдомлень немає.");
        return;
    }

    foreach (var group in groups)
    {
        Console.WriteLine();
        Console.WriteLine($"--- {group.GroupLabel} ---");
        foreach (var message in group.Messages)
        {
            PrintMessage(message);
        }
    }
}

void SearchMessages()
{
    Console.WriteLine();
    Console.WriteLine("=== Пошук повiдомлень ===");
    Console.Write("Запит: ");
    var query = Console.ReadLine()?.Trim() ?? string.Empty;

    var messages = messageService.Search(currentUser!.Email, query);
    ShowMessages(messages, $"Результати пошуку за '{query}'");
}

void FilterByDateRange()
{
    Console.WriteLine();
    Console.WriteLine("=== Фiльтрацiя за датою ===");
    Console.WriteLine("Введiть дату у форматi YYYY-MM-DD");
    Console.Write("Дата з: ");
    var fromInput = Console.ReadLine()?.Trim() ?? string.Empty;
    Console.Write("Дата по: ");
    var toInput = Console.ReadLine()?.Trim() ?? string.Empty;

    if (!DateTime.TryParse(fromInput, out var from))
    {
        Console.WriteLine("Неправильний формат дати початку.");
        return;
    }

    if (!DateTime.TryParse(toInput, out var to))
    {
        Console.WriteLine("Неправильний формат дати кiнця.");
        return;
    }

    try
    {
        var messages = messageService.GetByDateRange(currentUser!.Email, from, to);
        ShowMessages(messages, $"Повiдомлення з {from:yyyy-MM-dd} по {to:yyyy-MM-dd}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Не вдалося виконати фiльтрацiю: {ex.Message}");
    }
}

bool ChooseSortOrder()
{
    Console.WriteLine("Як сортувати? (1 - за спаданням, 2 - за зростанням, iнше - за спаданням)");
    Console.Write("Ваш вибiр: ");
    var input = Console.ReadLine()?.Trim();
    return input == "2";
}

void PrintMessage(MessageDto message)
{
    Console.WriteLine("--------------------");
    Console.WriteLine($"ID: {message.Id}");
    Console.WriteLine($"Вiд: {message.SenderEmail}");
    Console.WriteLine($"До: {message.RecipientEmail}");
    Console.WriteLine($"Тема: {message.Subject}");
    Console.WriteLine($"Розмiр: {message.SizeBytes} байт");
    Console.WriteLine($"Дата: {message.SentAt:u}");
    Console.WriteLine($"Текст: {message.Body}");
}

string ReadPassword()
{
    var password = string.Empty;
    while (true)
    {
        var key = Console.ReadKey(intercept: true);
        if (key.Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            break;
        }
        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
        {
            password = password[..^1];
            Console.Write("\b \b");
            continue;
        }

        password += key.KeyChar;
        Console.Write('*');
    }

    return password;
}
