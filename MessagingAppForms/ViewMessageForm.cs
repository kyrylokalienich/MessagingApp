using Messaging.Contracts.DTOs;

namespace MessagingAppForms;

public partial class ViewMessageForm : Form
{
    public ViewMessageForm(MessageDto message)
    {
        InitializeComponent();

        Text = $"Повідомлення — {message.Subject}";
        txtId.Text = message.Id.ToString();
        txtSender.Text = message.SenderEmail;
        txtRecipient.Text = message.RecipientEmail;
        txtSubject.Text = message.Subject;
        txtSentAt.Text = message.SentAt.ToString("u");
        txtSize.Text = $"{message.SizeBytes} байт";
        txtBody.Text = message.Body;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
