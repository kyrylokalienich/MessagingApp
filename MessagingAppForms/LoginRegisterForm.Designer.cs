namespace MessagingAppForms;

partial class LoginRegisterForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.GroupBox gbAuth;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label lblStatus;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.gbAuth = new System.Windows.Forms.GroupBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.btnRegister = new System.Windows.Forms.Button();
        this.btnLogin = new System.Windows.Forms.Button();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.labelPassword = new System.Windows.Forms.Label();
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.labelLogin = new System.Windows.Forms.Label();
        this.gbAuth.SuspendLayout();
        this.SuspendLayout();
        // 
        // gbAuth
        // 
        this.gbAuth.Controls.Add(this.lblStatus);
        this.gbAuth.Controls.Add(this.btnRegister);
        this.gbAuth.Controls.Add(this.btnLogin);
        this.gbAuth.Controls.Add(this.txtPassword);
        this.gbAuth.Controls.Add(this.labelPassword);
        this.gbAuth.Controls.Add(this.txtLogin);
        this.gbAuth.Controls.Add(this.labelLogin);
        this.gbAuth.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbAuth.Location = new System.Drawing.Point(0, 0);
        this.gbAuth.Name = "gbAuth";
        this.gbAuth.Padding = new System.Windows.Forms.Padding(15);
        this.gbAuth.Size = new System.Drawing.Size(484, 201);
        this.gbAuth.TabIndex = 0;
        this.gbAuth.TabStop = false;
        this.gbAuth.Text = "Авторизація";
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(18, 140);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(0, 15);
        this.lblStatus.TabIndex = 6;
        // 
        // btnRegister
        // 
        this.btnRegister.Location = new System.Drawing.Point(253, 98);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(100, 25);
        this.btnRegister.TabIndex = 5;
        this.btnRegister.Text = "Зареєструватись";
        this.btnRegister.UseVisualStyleBackColor = true;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        // 
        // btnLogin
        // 
        this.btnLogin.Location = new System.Drawing.Point(147, 98);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(100, 25);
        this.btnLogin.TabIndex = 4;
        this.btnLogin.Text = "Увійти";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // txtPassword
        // 
        this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtPassword.Location = new System.Drawing.Point(83, 63);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(383, 23);
        this.txtPassword.TabIndex = 3;
        // 
        // labelPassword
        // 
        this.labelPassword.AutoSize = true;
        this.labelPassword.Location = new System.Drawing.Point(18, 66);
        this.labelPassword.Name = "labelPassword";
        this.labelPassword.Size = new System.Drawing.Size(52, 15);
        this.labelPassword.TabIndex = 2;
        this.labelPassword.Text = "Пароль:";
        // 
        // txtLogin
        // 
        this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtLogin.Location = new System.Drawing.Point(83, 31);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(383, 23);
        this.txtLogin.TabIndex = 1;
        // 
        // labelLogin
        // 
        this.labelLogin.AutoSize = true;
        this.labelLogin.Location = new System.Drawing.Point(18, 34);
        this.labelLogin.Name = "labelLogin";
        this.labelLogin.Size = new System.Drawing.Size(41, 15);
        this.labelLogin.TabIndex = 0;
        this.labelLogin.Text = "Логін:";
        // 
        // LoginRegisterForm
        // 
        this.AcceptButton = this.btnLogin;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 201);
        this.Controls.Add(this.gbAuth);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "LoginRegisterForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "MessagingApp — Вхід";
        this.gbAuth.ResumeLayout(false);
        this.gbAuth.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
