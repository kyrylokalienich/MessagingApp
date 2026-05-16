namespace MessagingAppForms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.GroupBox gbAuth;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Label lblUserStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.GroupBox gbCompose;
    private System.Windows.Forms.Label labelRecipient;
    private System.Windows.Forms.TextBox txtRecipient;
    private System.Windows.Forms.Label labelSubject;
    private System.Windows.Forms.TextBox txtSubject;
    private System.Windows.Forms.Label labelBody;
    private System.Windows.Forms.TextBox txtBody;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.GroupBox gbActions;
    private System.Windows.Forms.ComboBox cmbSortOrder;
    private System.Windows.Forms.Label labelSort;
    private System.Windows.Forms.Button btnInbox;
    private System.Windows.Forms.Button btnSent;
    private System.Windows.Forms.Button btnInboxGroup;
    private System.Windows.Forms.Button btnSentGroup;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label labelFrom;
    private System.Windows.Forms.DateTimePicker dtpFrom;
    private System.Windows.Forms.Label labelTo;
    private System.Windows.Forms.DateTimePicker dtpTo;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.GroupBox gbResults;
    private System.Windows.Forms.Label lblResultsHeader;
    private System.Windows.Forms.ListView lvMessages;
    private System.Windows.Forms.TextBox txtDetails;

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
        this.lblUserStatus = new System.Windows.Forms.Label();
        this.btnLogout = new System.Windows.Forms.Button();
        this.btnRegister = new System.Windows.Forms.Button();
        this.btnLogin = new System.Windows.Forms.Button();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.labelPassword = new System.Windows.Forms.Label();
        this.txtLogin = new System.Windows.Forms.TextBox();
        this.labelLogin = new System.Windows.Forms.Label();
        this.gbCompose = new System.Windows.Forms.GroupBox();
        this.btnSend = new System.Windows.Forms.Button();
        this.txtBody = new System.Windows.Forms.TextBox();
        this.labelBody = new System.Windows.Forms.Label();
        this.txtSubject = new System.Windows.Forms.TextBox();
        this.labelSubject = new System.Windows.Forms.Label();
        this.txtRecipient = new System.Windows.Forms.TextBox();
        this.labelRecipient = new System.Windows.Forms.Label();
        this.gbActions = new System.Windows.Forms.GroupBox();
        this.btnFilter = new System.Windows.Forms.Button();
        this.dtpTo = new System.Windows.Forms.DateTimePicker();
        this.labelTo = new System.Windows.Forms.Label();
        this.dtpFrom = new System.Windows.Forms.DateTimePicker();
        this.labelFrom = new System.Windows.Forms.Label();
        this.btnSearch = new System.Windows.Forms.Button();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.labelSearch = new System.Windows.Forms.Label();
        this.btnSentGroup = new System.Windows.Forms.Button();
        this.btnInboxGroup = new System.Windows.Forms.Button();
        this.btnSent = new System.Windows.Forms.Button();
        this.btnInbox = new System.Windows.Forms.Button();
        this.labelSort = new System.Windows.Forms.Label();
        this.cmbSortOrder = new System.Windows.Forms.ComboBox();
        this.gbResults = new System.Windows.Forms.GroupBox();
        this.txtDetails = new System.Windows.Forms.TextBox();
        this.lvMessages = new System.Windows.Forms.ListView();
        this.lblResultsHeader = new System.Windows.Forms.Label();
        this.gbAuth.SuspendLayout();
        this.gbCompose.SuspendLayout();
        this.gbActions.SuspendLayout();
        this.gbResults.SuspendLayout();
        this.SuspendLayout();
        // 
        // gbAuth
        // 
        this.gbAuth.Controls.Add(this.lblStatus);
        this.gbAuth.Controls.Add(this.lblUserStatus);
        this.gbAuth.Controls.Add(this.btnLogout);
        this.gbAuth.Controls.Add(this.btnRegister);
        this.gbAuth.Controls.Add(this.btnLogin);
        this.gbAuth.Controls.Add(this.txtPassword);
        this.gbAuth.Controls.Add(this.labelPassword);
        this.gbAuth.Controls.Add(this.txtLogin);
        this.gbAuth.Controls.Add(this.labelLogin);
        this.gbAuth.Location = new System.Drawing.Point(10, 10);
        this.gbAuth.Name = "gbAuth";
        this.gbAuth.Size = new System.Drawing.Size(480, 170);
        this.gbAuth.TabIndex = 0;
        this.gbAuth.TabStop = false;
        this.gbAuth.Text = "Авторизація";
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(15, 140);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(0, 15);
        this.lblStatus.TabIndex = 8;
        // 
        // lblUserStatus
        // 
        this.lblUserStatus.AutoSize = true;
        this.lblUserStatus.Location = new System.Drawing.Point(15, 115);
        this.lblUserStatus.Name = "lblUserStatus";
        this.lblUserStatus.Size = new System.Drawing.Size(101, 15);
        this.lblUserStatus.TabIndex = 7;
        this.lblUserStatus.Text = "Не виконано вхід";
        // 
        // btnLogout
        // 
        this.btnLogout.Location = new System.Drawing.Point(356, 73);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(110, 25);
        this.btnLogout.TabIndex = 6;
        this.btnLogout.Text = "Вийти";
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        // 
        // btnRegister
        // 
        this.btnRegister.Location = new System.Drawing.Point(250, 73);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(100, 25);
        this.btnRegister.TabIndex = 5;
        this.btnRegister.Text = "Зареєструватись";
        this.btnRegister.UseVisualStyleBackColor = true;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        // 
        // btnLogin
        // 
        this.btnLogin.Location = new System.Drawing.Point(144, 73);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(100, 25);
        this.btnLogin.TabIndex = 4;
        this.btnLogin.Text = "Увійти";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(80, 45);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(386, 23);
        this.txtPassword.TabIndex = 3;
        // 
        // labelPassword
        // 
        this.labelPassword.AutoSize = true;
        this.labelPassword.Location = new System.Drawing.Point(15, 48);
        this.labelPassword.Name = "labelPassword";
        this.labelPassword.Size = new System.Drawing.Size(52, 15);
        this.labelPassword.TabIndex = 2;
        this.labelPassword.Text = "Пароль:";
        // 
        // txtLogin
        // 
        this.txtLogin.Location = new System.Drawing.Point(80, 19);
        this.txtLogin.Name = "txtLogin";
        this.txtLogin.Size = new System.Drawing.Size(386, 23);
        this.txtLogin.TabIndex = 1;
        // 
        // labelLogin
        // 
        this.labelLogin.AutoSize = true;
        this.labelLogin.Location = new System.Drawing.Point(15, 22);
        this.labelLogin.Name = "labelLogin";
        this.labelLogin.Size = new System.Drawing.Size(41, 15);
        this.labelLogin.TabIndex = 0;
        this.labelLogin.Text = "Логін:";
        // 
        // gbCompose
        // 
        this.gbCompose.Controls.Add(this.btnSend);
        this.gbCompose.Controls.Add(this.txtBody);
        this.gbCompose.Controls.Add(this.labelBody);
        this.gbCompose.Controls.Add(this.txtSubject);
        this.gbCompose.Controls.Add(this.labelSubject);
        this.gbCompose.Controls.Add(this.txtRecipient);
        this.gbCompose.Controls.Add(this.labelRecipient);
        this.gbCompose.Location = new System.Drawing.Point(500, 10);
        this.gbCompose.Name = "gbCompose";
        this.gbCompose.Size = new System.Drawing.Size(470, 225);
        this.gbCompose.TabIndex = 1;
        this.gbCompose.TabStop = false;
        this.gbCompose.Text = "Надіслати повідомлення";
        // 
        // btnSend
        // 
        this.btnSend.Location = new System.Drawing.Point(345, 187);
        this.btnSend.Name = "btnSend";
        this.btnSend.Size = new System.Drawing.Size(110, 25);
        this.btnSend.TabIndex = 6;
        this.btnSend.Text = "Надіслати";
        this.btnSend.UseVisualStyleBackColor = true;
        this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
        // 
        // txtBody
        // 
        this.txtBody.Location = new System.Drawing.Point(80, 71);
        this.txtBody.Multiline = true;
        this.txtBody.Name = "txtBody";
        this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtBody.Size = new System.Drawing.Size(375, 110);
        this.txtBody.TabIndex = 5;
        // 
        // labelBody
        // 
        this.labelBody.AutoSize = true;
        this.labelBody.Location = new System.Drawing.Point(15, 74);
        this.labelBody.Name = "labelBody";
        this.labelBody.Size = new System.Drawing.Size(35, 15);
        this.labelBody.TabIndex = 4;
        this.labelBody.Text = "Текст:";
        // 
        // txtSubject
        // 
        this.txtSubject.Location = new System.Drawing.Point(80, 45);
        this.txtSubject.Name = "txtSubject";
        this.txtSubject.Size = new System.Drawing.Size(375, 23);
        this.txtSubject.TabIndex = 3;
        // 
        // labelSubject
        // 
        this.labelSubject.AutoSize = true;
        this.labelSubject.Location = new System.Drawing.Point(15, 48);
        this.labelSubject.Name = "labelSubject";
        this.labelSubject.Size = new System.Drawing.Size(44, 15);
        this.labelSubject.TabIndex = 2;
        this.labelSubject.Text = "Тема:";
        // 
        // txtRecipient
        // 
        this.txtRecipient.Location = new System.Drawing.Point(80, 19);
        this.txtRecipient.Name = "txtRecipient";
        this.txtRecipient.Size = new System.Drawing.Size(375, 23);
        this.txtRecipient.TabIndex = 1;
        // 
        // labelRecipient
        // 
        this.labelRecipient.AutoSize = true;
        this.labelRecipient.Location = new System.Drawing.Point(15, 22);
        this.labelRecipient.Name = "labelRecipient";
        this.labelRecipient.Size = new System.Drawing.Size(64, 15);
        this.labelRecipient.TabIndex = 0;
        this.labelRecipient.Text = "До (email):";
        // 
        // gbActions
        // 
        this.gbActions.Controls.Add(this.btnFilter);
        this.gbActions.Controls.Add(this.dtpTo);
        this.gbActions.Controls.Add(this.labelTo);
        this.gbActions.Controls.Add(this.dtpFrom);
        this.gbActions.Controls.Add(this.labelFrom);
        this.gbActions.Controls.Add(this.btnSearch);
        this.gbActions.Controls.Add(this.txtSearch);
        this.gbActions.Controls.Add(this.labelSearch);
        this.gbActions.Controls.Add(this.btnSentGroup);
        this.gbActions.Controls.Add(this.btnInboxGroup);
        this.gbActions.Controls.Add(this.btnSent);
        this.gbActions.Controls.Add(this.btnInbox);
        this.gbActions.Controls.Add(this.labelSort);
        this.gbActions.Controls.Add(this.cmbSortOrder);
        this.gbActions.Location = new System.Drawing.Point(10, 190);
        this.gbActions.Name = "gbActions";
        this.gbActions.Size = new System.Drawing.Size(480, 260);
        this.gbActions.TabIndex = 2;
        this.gbActions.TabStop = false;
        this.gbActions.Text = "Операції з повідомленнями";
        // 
        // btnFilter
        // 
        this.btnFilter.Location = new System.Drawing.Point(345, 215);
        this.btnFilter.Name = "btnFilter";
        this.btnFilter.Size = new System.Drawing.Size(110, 25);
        this.btnFilter.TabIndex = 13;
        this.btnFilter.Text = "Фільтрувати";
        this.btnFilter.UseVisualStyleBackColor = true;
        this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
        // 
        // dtpTo
        // 
        this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpTo.Location = new System.Drawing.Point(80, 217);
        this.dtpTo.Name = "dtpTo";
        this.dtpTo.Size = new System.Drawing.Size(145, 23);
        this.dtpTo.TabIndex = 12;
        // 
        // labelTo
        // 
        this.labelTo.AutoSize = true;
        this.labelTo.Location = new System.Drawing.Point(15, 221);
        this.labelTo.Name = "labelTo";
        this.labelTo.Size = new System.Drawing.Size(25, 15);
        this.labelTo.TabIndex = 11;
        this.labelTo.Text = "По:";
        // 
        // dtpFrom
        // 
        this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFrom.Location = new System.Drawing.Point(80, 187);
        this.dtpFrom.Name = "dtpFrom";
        this.dtpFrom.Size = new System.Drawing.Size(145, 23);
        this.dtpFrom.TabIndex = 10;
        // 
        // labelFrom
        // 
        this.labelFrom.AutoSize = true;
        this.labelFrom.Location = new System.Drawing.Point(15, 191);
        this.labelFrom.Name = "labelFrom";
        this.labelFrom.Size = new System.Drawing.Size(55, 15);
        this.labelFrom.TabIndex = 9;
        this.labelFrom.Text = "Дата з:";
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new System.Drawing.Point(345, 143);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(110, 25);
        this.btnSearch.TabIndex = 8;
        this.btnSearch.Text = "Пошук";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new System.Drawing.Point(80, 145);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(251, 23);
        this.txtSearch.TabIndex = 7;
        // 
        // labelSearch
        // 
        this.labelSearch.AutoSize = true;
        this.labelSearch.Location = new System.Drawing.Point(15, 148);
        this.labelSearch.Name = "labelSearch";
        this.labelSearch.Size = new System.Drawing.Size(44, 15);
        this.labelSearch.TabIndex = 6;
        this.labelSearch.Text = "Запит:";
        // 
        // btnSentGroup
        // 
        this.btnSentGroup.Location = new System.Drawing.Point(250, 105);
        this.btnSentGroup.Name = "btnSentGroup";
        this.btnSentGroup.Size = new System.Drawing.Size(205, 25);
        this.btnSentGroup.TabIndex = 5;
        this.btnSentGroup.Text = "Надіслані згруповані";
        this.btnSentGroup.UseVisualStyleBackColor = true;
        this.btnSentGroup.Click += new System.EventHandler(this.btnSentGroup_Click);
        // 
        // btnInboxGroup
        // 
        this.btnInboxGroup.Location = new System.Drawing.Point(20, 105);
        this.btnInboxGroup.Name = "btnInboxGroup";
        this.btnInboxGroup.Size = new System.Drawing.Size(205, 25);
        this.btnInboxGroup.TabIndex = 4;
        this.btnInboxGroup.Text = "Вхідні згруповані";
        this.btnInboxGroup.UseVisualStyleBackColor = true;
        this.btnInboxGroup.Click += new System.EventHandler(this.btnInboxGroup_Click);
        // 
        // btnSent
        // 
        this.btnSent.Location = new System.Drawing.Point(250, 70);
        this.btnSent.Name = "btnSent";
        this.btnSent.Size = new System.Drawing.Size(205, 25);
        this.btnSent.TabIndex = 3;
        this.btnSent.Text = "Надіслані";
        this.btnSent.UseVisualStyleBackColor = true;
        this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
        // 
        // btnInbox
        // 
        this.btnInbox.Location = new System.Drawing.Point(20, 70);
        this.btnInbox.Name = "btnInbox";
        this.btnInbox.Size = new System.Drawing.Size(205, 25);
        this.btnInbox.TabIndex = 2;
        this.btnInbox.Text = "Вхідні";
        this.btnInbox.UseVisualStyleBackColor = true;
        this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
        // 
        // labelSort
        // 
        this.labelSort.AutoSize = true;
        this.labelSort.Location = new System.Drawing.Point(15, 30);
        this.labelSort.Name = "labelSort";
        this.labelSort.Size = new System.Drawing.Size(97, 15);
        this.labelSort.TabIndex = 1;
        this.labelSort.Text = "Порядок сортування:";
        // 
        // cmbSortOrder
        // 
        this.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSortOrder.FormattingEnabled = true;
        this.cmbSortOrder.Location = new System.Drawing.Point(120, 27);
        this.cmbSortOrder.Name = "cmbSortOrder";
        this.cmbSortOrder.Size = new System.Drawing.Size(335, 23);
        this.cmbSortOrder.TabIndex = 0;
        // 
        // gbResults
        // 
        this.gbResults.Controls.Add(this.txtDetails);
        this.gbResults.Controls.Add(this.lvMessages);
        this.gbResults.Controls.Add(this.lblResultsHeader);
        this.gbResults.Location = new System.Drawing.Point(500, 245);
        this.gbResults.Name = "gbResults";
        this.gbResults.Size = new System.Drawing.Size(470, 445);
        this.gbResults.TabIndex = 3;
        this.gbResults.TabStop = false;
        this.gbResults.Text = "Результати";
        // 
        // txtDetails
        // 
        this.txtDetails.Location = new System.Drawing.Point(15, 320);
        this.txtDetails.Multiline = true;
        this.txtDetails.Name = "txtDetails";
        this.txtDetails.ReadOnly = true;
        this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtDetails.Size = new System.Drawing.Size(440, 110);
        this.txtDetails.TabIndex = 2;
        // 
        // lvMessages
        // 
        this.lvMessages.HideSelection = false;
        this.lvMessages.Location = new System.Drawing.Point(15, 40);
        this.lvMessages.Name = "lvMessages";
        this.lvMessages.Size = new System.Drawing.Size(440, 270);
        this.lvMessages.TabIndex = 1;
        this.lvMessages.UseCompatibleStateImageBehavior = false;
        this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
        // 
        // lblResultsHeader
        // 
        this.lblResultsHeader.AutoSize = true;
        this.lblResultsHeader.Location = new System.Drawing.Point(15, 22);
        this.lblResultsHeader.Name = "lblResultsHeader";
        this.lblResultsHeader.Size = new System.Drawing.Size(64, 15);
        this.lblResultsHeader.TabIndex = 0;
        this.lblResultsHeader.Text = "Результати";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(984, 701);
        this.Controls.Add(this.gbResults);
        this.Controls.Add(this.gbActions);
        this.Controls.Add(this.gbCompose);
        this.Controls.Add(this.gbAuth);
        this.MinimumSize = new System.Drawing.Size(1000, 740);
        this.Name = "MainForm";
        this.Text = "MessagingApp GUI";
        this.gbAuth.ResumeLayout(false);
        this.gbAuth.PerformLayout();
        this.gbCompose.ResumeLayout(false);
        this.gbCompose.PerformLayout();
        this.gbActions.ResumeLayout(false);
        this.gbActions.PerformLayout();
        this.gbResults.ResumeLayout(false);
        this.gbResults.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
