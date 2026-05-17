using Messaging.Contracts.DTOs;

namespace MessagingAppForms;

public partial class SendMailForm : Form
{
    private readonly AppSession session = AppSession.Instance;

    public SendMailForm()
    {
        InitializeComponent();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        var currentUser = session.CurrentUser;
        if (currentUser == null)
        {
            SetStatus("Будь ласка, увійдіть, щоб надсилати повідомлення.", true);
            DialogResult = DialogResult.Cancel;
            Close();
            return;
        }

        try
        {
            var request = new SendMessageRequest(txtRecipient.Text.Trim(), txtSubject.Text.Trim(), txtBody.Text);
            var message = session.MessageService.Send(currentUser.Email, request);
            SetStatus($"Повідомлення надіслано. Розмір: {message.SizeBytes} байт, Дата: {message.SentAt:u}", false);
            txtBody.Clear();
            txtRecipient.Clear();
            txtSubject.Clear();
        }
        catch (Exception ex)
        {
            SetStatus($"Не вдалося надіслати повідомлення: {ex.Message}", true);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SetStatus(string message, bool isError)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = isError ? Color.DarkRed : Color.DarkGreen;
    }
}
