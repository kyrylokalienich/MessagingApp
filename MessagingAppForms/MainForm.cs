using Messaging.Contracts.DTOs;
using Messaging.Contracts.Services;
using Messaging.Services;
using Messaging.Storage;

namespace MessagingAppForms;

public partial class MainForm : Form
{
    private readonly IAuthService authService;
    private readonly IMessageService messageService;
    private UserDto? currentUser;

    public MainForm()
    {
        InitializeComponent();

        var userRepo = new JsonUserRepository("data");
        var messageRepo = new JsonMessageRepository("data");

        authService = new AuthService(userRepo);
        messageService = new MessageService(messageRepo);

        cmbSortOrder.Items.AddRange(new object[] { "За спаданням", "За зростанням" });
        cmbSortOrder.SelectedIndex = 0;

        lvMessages.Columns.Add("ID", 220);
        lvMessages.Columns.Add("Від", 180);
        lvMessages.Columns.Add("До", 180);
        lvMessages.Columns.Add("Тема", 220);
        lvMessages.Columns.Add("Дата", 160);
        lvMessages.View = View.Details;
        lvMessages.FullRowSelect = true;
        lvMessages.GridLines = true;
        lvMessages.HideSelection = false;

        SetCurrentUser(null);
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            var request = new RegisterRequest(txtLogin.Text.Trim(), txtPassword.Text);
            var user = authService.Register(request);
            SetStatus($"Реєстрація успішна. Ваш email: {user.Email}", false);
            txtPassword.Clear();
        }
        catch (Exception ex)
        {
            SetStatus(ex.Message, true);
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            var request = new LoginRequest(txtLogin.Text.Trim(), txtPassword.Text);
            var user = authService.Login(request);
            SetCurrentUser(user);
            SetStatus($"Вхід успішний. Привіт, {user.Login}!", false);
            txtPassword.Clear();
        }
        catch (Exception ex)
        {
            SetStatus($"Не вдалося авторизуватися: {ex.Message}", true);
        }
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        SetCurrentUser(null);
        SetStatus("Ви вийшли з облікового запису.", false);
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        try
        {
            var request = new SendMessageRequest(txtRecipient.Text.Trim(), txtSubject.Text.Trim(), txtBody.Text);
            var message = messageService.Send(currentUser!.Email, request);
            SetStatus($"Повідомлення надіслано. Розмір: {message.SizeBytes} байт, Дата: {message.SentAt:u}", false);
            txtBody.Clear();
        }
        catch (Exception ex)
        {
            SetStatus($"Не вдалося надіслати повідомлення: {ex.Message}", true);
        }
    }

    private void btnInbox_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = messageService.GetInbox(currentUser!.Email, GetSortAscending());
        DisplayMessages(messages, "Вхідні повідомлення");
    }

    private void btnSent_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = messageService.GetSent(currentUser!.Email, GetSortAscending());
        DisplayMessages(messages, "Надіслані повідомлення");
    }

    private void btnInboxGroup_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var groups = messageService.GetInboxGrouped(currentUser!.Email);
        DisplayGroupedMessages(groups, "Вхідні повідомлення, згруповані за часом");
    }

    private void btnSentGroup_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var groups = messageService.GetSentGrouped(currentUser!.Email);
        DisplayGroupedMessages(groups, "Надіслані повідомлення, згруповані за часом");
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = messageService.Search(currentUser!.Email, txtSearch.Text.Trim());
        DisplayMessages(messages, $"Результати пошуку: '{txtSearch.Text.Trim()}'");
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var from = dtpFrom.Value.Date;
        var to = dtpTo.Value.Date;

        try
        {
            var messages = messageService.GetByDateRange(currentUser!.Email, from, to);
            DisplayMessages(messages, $"Повідомлення з {from:yyyy-MM-dd} по {to:yyyy-MM-dd}");
        }
        catch (Exception ex)
        {
            SetStatus(ex.Message, true);
        }
    }

    private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvMessages.SelectedItems.Count == 0)
        {
            txtDetails.Clear();
            return;
        }

        if (lvMessages.SelectedItems[0].Tag is MessageDto message)
        {
            txtDetails.Text = BuildMessageDetails(message);
        }
    }

    private void DisplayMessages(IReadOnlyList<MessageDto> messages, string header)
    {
        lblResultsHeader.Text = header;
        lvMessages.BeginUpdate();
        lvMessages.Groups.Clear();
        lvMessages.Items.Clear();

        var group = new System.Windows.Forms.ListViewGroup("messagesGroup", header);
        lvMessages.Groups.Add(group);

        foreach (var message in messages)
        {
            var item = new System.Windows.Forms.ListViewItem(message.Id.ToString()) { Group = group, Tag = message };
            item.SubItems.Add(message.SenderEmail);
            item.SubItems.Add(message.RecipientEmail);
            item.SubItems.Add(message.Subject);
            item.SubItems.Add(message.SentAt.ToString("u"));
            lvMessages.Items.Add(item);
        }

        lvMessages.EndUpdate();
        txtDetails.Clear();

        if (!messages.Any())
            SetStatus("Повідомлень не знайдено.", false);
    }

    private void DisplayGroupedMessages(IReadOnlyList<MessageGroupDto> groups, string header)
    {
        lblResultsHeader.Text = header;
        lvMessages.BeginUpdate();
        lvMessages.Groups.Clear();
        lvMessages.Items.Clear();

        foreach (var groupData in groups)
        {
            var group = new System.Windows.Forms.ListViewGroup(groupData.GroupLabel, groupData.GroupLabel);
            lvMessages.Groups.Add(group);

            foreach (var message in groupData.Messages)
            {
                var item = new System.Windows.Forms.ListViewItem(message.Id.ToString()) { Group = group, Tag = message };
                item.SubItems.Add(message.SenderEmail);
                item.SubItems.Add(message.RecipientEmail);
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.SentAt.ToString("u"));
                lvMessages.Items.Add(item);
            }
        }

        lvMessages.EndUpdate();
        txtDetails.Clear();

        if (!lvMessages.Items.Cast<System.Windows.Forms.ListViewItem>().Any())
            SetStatus("Повідомлень не знайдено.", false);
    }

    private bool GetSortAscending() => cmbSortOrder.SelectedIndex == 1;

    private bool EnsureLoggedIn()
    {
        if (currentUser != null)
            return true;

        SetStatus("Будь ласка, увійдіть, щоб працювати з повідомленнями.", true);
        return false;
    }

    private void SetCurrentUser(UserDto? user)
    {
        currentUser = user;
        bool loggedIn = currentUser != null;

        lblUserStatus.Text = loggedIn
            ? $"Увійшли як: {currentUser!.Login} ({currentUser.Email})"
            : "Не виконано вхід";

        gbCompose.Enabled = loggedIn;
        gbActions.Enabled = loggedIn;
        btnLogout.Enabled = loggedIn;
        btnLogin.Enabled = !loggedIn;
        btnRegister.Enabled = !loggedIn;
        txtLogin.Enabled = !loggedIn;
        txtPassword.Enabled = !loggedIn;

        if (!loggedIn)
        {
            ClearMessages();
            txtRecipient.Clear();
            txtSubject.Clear();
            txtBody.Clear();
        }
    }

    private void ClearMessages()
    {
        lvMessages.Items.Clear();
        lvMessages.Groups.Clear();
        txtDetails.Clear();
        lblResultsHeader.Text = "Результати";
    }

    private void SetStatus(string message, bool isError)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = isError ? System.Drawing.Color.DarkRed : System.Drawing.Color.DarkGreen;
    }

    private static string BuildMessageDetails(MessageDto message)
    {
        return $"ID: {message.Id}{Environment.NewLine}" +
               $"Від: {message.SenderEmail}{Environment.NewLine}" +
               $"До: {message.RecipientEmail}{Environment.NewLine}" +
               $"Тема: {message.Subject}{Environment.NewLine}" +
               $"Дата: {message.SentAt:u}{Environment.NewLine}" +
               $"Розмір: {message.SizeBytes} байт{Environment.NewLine}{Environment.NewLine}" +
               $"Текст:{Environment.NewLine}{message.Body}";
    }
}
