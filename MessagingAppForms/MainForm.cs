using Messaging.Contracts.DTOs;

namespace MessagingAppForms;

public partial class MainForm : Form
{
    private readonly AppSession session = AppSession.Instance;

    public MainForm()
    {
        InitializeComponent();

        cmbSortOrder.Items.AddRange(new object[] { "За спаданням", "За зростанням" });
        cmbSortOrder.SelectedIndex = 0;

        lvMessages.Columns.Add("ID", 60);
        lvMessages.Columns.Add("Від", 180);
        lvMessages.Columns.Add("До", 180);
        lvMessages.Columns.Add("Тема", 220);
        lvMessages.Columns.Add("Дата", 160);
        lvMessages.View = View.Details;
        lvMessages.FullRowSelect = true;
        lvMessages.GridLines = true;
        lvMessages.HideSelection = false;

        UpdateUserStatus();
    }

    private void btnNewLetter_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        using var sendForm = new SendMailForm();
        sendForm.ShowDialog(this);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        session.CurrentUser = null;
        Close();
    }

    private void btnInbox_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = session.MessageService.GetInbox(session.CurrentUser!.Email, GetSortAscending());
        DisplayMessages(messages, "Вхідні повідомлення");
    }

    private void btnSent_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = session.MessageService.GetSent(session.CurrentUser!.Email, GetSortAscending());
        DisplayMessages(messages, "Надіслані повідомлення");
    }

    private void btnInboxGroup_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var groups = session.MessageService.GetInboxGrouped(session.CurrentUser!.Email);
        DisplayGroupedMessages(groups, "Вхідні повідомлення, згруповані за часом");
    }

    private void btnSentGroup_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var groups = session.MessageService.GetSentGrouped(session.CurrentUser!.Email);
        DisplayGroupedMessages(groups, "Надіслані повідомлення, згруповані за часом");
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        var messages = session.MessageService.Search(session.CurrentUser!.Email, txtSearch.Text.Trim());
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
            var messages = session.MessageService.GetByDateRange(session.CurrentUser!.Email, from, to);
            DisplayMessages(messages, $"Повідомлення з {from:yyyy-MM-dd} по {to:yyyy-MM-dd}");
        }
        catch (Exception ex)
        {
            SetStatus(ex.Message, true);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!EnsureLoggedIn())
            return;

        if (lvMessages.SelectedItems.Count == 0)
        {
            SetStatus("Оберіть повідомлення для видалення.", true);
            return;
        }

        if (lvMessages.SelectedItems[0].Tag is not MessageDto message)
            return;

        var confirm = MessageBox.Show(
            $"Видалити повідомлення «{message.Subject}»?",
            "Підтвердження видалення",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
            return;

        try
        {
            session.MessageService.DeleteMessage(session.CurrentUser!.Email, message.Id);
            lvMessages.SelectedItems[0].Remove();
            txtDetails.Clear();
            SetStatus("Повідомлення видалено.", false);
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

        var group = new ListViewGroup("messagesGroup", header);
        lvMessages.Groups.Add(group);

        foreach (var message in messages)
        {
            var item = new ListViewItem(message.Id.ToString()) { Group = group, Tag = message };
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
            var group = new ListViewGroup(groupData.GroupLabel, groupData.GroupLabel);
            lvMessages.Groups.Add(group);

            foreach (var message in groupData.Messages)
            {
                var item = new ListViewItem(message.Id.ToString()) { Group = group, Tag = message };
                item.SubItems.Add(message.SenderEmail);
                item.SubItems.Add(message.RecipientEmail);
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.SentAt.ToString("u"));
                lvMessages.Items.Add(item);
            }
        }

        lvMessages.EndUpdate();
        txtDetails.Clear();

        if (!lvMessages.Items.Cast<ListViewItem>().Any())
            SetStatus("Повідомлень не знайдено.", false);
    }

    private bool GetSortAscending() => cmbSortOrder.SelectedIndex == 1;

    private bool EnsureLoggedIn()
    {
        if (session.CurrentUser != null)
            return true;

        SetStatus("Будь ласка, увійдіть, щоб працювати з повідомленнями.", true);
        return false;
    }

    private void UpdateUserStatus()
    {
        var user = session.CurrentUser;
        lblUserStatus.Text = user != null
            ? $"Увійшли як: {user.Login} ({user.Email})"
            : "Не виконано вхід";
    }

    private void SetStatus(string message, bool isError)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = isError ? Color.DarkRed : Color.DarkGreen;
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
