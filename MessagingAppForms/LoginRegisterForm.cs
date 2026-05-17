using Messaging.Contracts.DTOs;

namespace MessagingAppForms;

public partial class LoginRegisterForm : Form
{
    private readonly AppSession session = AppSession.Instance;

    public LoginRegisterForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            var request = new RegisterRequest(txtLogin.Text.Trim(), txtPassword.Text);
            var user = session.AuthService.Register(request);
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
            var user = session.AuthService.Login(request);
            session.CurrentUser = user;
            OpenMainForm();
        }
        catch (Exception ex)
        {
            SetStatus($"Не вдалося авторизуватися: {ex.Message}", true);
        }
    }

    private void OpenMainForm()
    {
        Hide();
        using var mainForm = new MainForm();
        mainForm.FormClosed += (_, _) =>
        {
            session.CurrentUser = null;
            txtPassword.Clear();
            SetStatus(string.Empty, false);
            Show();
            Activate();
        };
        mainForm.ShowDialog();
    }

    private void SetStatus(string message, bool isError)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = isError ? Color.DarkRed : Color.DarkGreen;
    }
}
