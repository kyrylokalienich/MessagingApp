namespace MessagingAppForms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblUserStatus;
    private System.Windows.Forms.Button btnNewLetter;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Label lblStatus;
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
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblStatus = new System.Windows.Forms.Label();
        this.btnLogout = new System.Windows.Forms.Button();
        this.btnNewLetter = new System.Windows.Forms.Button();
        this.lblUserStatus = new System.Windows.Forms.Label();
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
        this.pnlHeader.SuspendLayout();
        this.gbActions.SuspendLayout();
        this.gbResults.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.Controls.Add(this.lblStatus);
        this.pnlHeader.Controls.Add(this.btnLogout);
        this.pnlHeader.Controls.Add(this.btnNewLetter);
        this.pnlHeader.Controls.Add(this.lblUserStatus);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Padding = new System.Windows.Forms.Padding(10);
        this.pnlHeader.Size = new System.Drawing.Size(984, 70);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(13, 45);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(0, 15);
        this.lblStatus.TabIndex = 3;
        // 
        // btnLogout
        // 
        this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLogout.Location = new System.Drawing.Point(862, 10);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(110, 25);
        this.btnLogout.TabIndex = 2;
        this.btnLogout.Text = "Вийти";
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        // 
        // btnNewLetter
        // 
        this.btnNewLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnNewLetter.Location = new System.Drawing.Point(736, 10);
        this.btnNewLetter.Name = "btnNewLetter";
        this.btnNewLetter.Size = new System.Drawing.Size(120, 25);
        this.btnNewLetter.TabIndex = 1;
        this.btnNewLetter.Text = "Новий лист";
        this.btnNewLetter.UseVisualStyleBackColor = true;
        this.btnNewLetter.Click += new System.EventHandler(this.btnNewLetter_Click);
        // 
        // lblUserStatus
        // 
        this.lblUserStatus.AutoSize = true;
        this.lblUserStatus.Location = new System.Drawing.Point(13, 15);
        this.lblUserStatus.Name = "lblUserStatus";
        this.lblUserStatus.Size = new System.Drawing.Size(101, 15);
        this.lblUserStatus.TabIndex = 0;
        this.lblUserStatus.Text = "Не виконано вхід";
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
        this.gbActions.Dock = System.Windows.Forms.DockStyle.Left;
        this.gbActions.Location = new System.Drawing.Point(0, 70);
        this.gbActions.Name = "gbActions";
        this.gbActions.Padding = new System.Windows.Forms.Padding(10);
        this.gbActions.Size = new System.Drawing.Size(500, 631);
        this.gbActions.TabIndex = 1;
        this.gbActions.TabStop = false;
        this.gbActions.Text = "Операції з повідомленнями";
        // 
        // btnFilter
        // 
        this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnFilter.Location = new System.Drawing.Point(365, 215);
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
        this.dtpTo.Location = new System.Drawing.Point(100, 217);
        this.dtpTo.Name = "dtpTo";
        this.dtpTo.Size = new System.Drawing.Size(145, 23);
        this.dtpTo.TabIndex = 12;
        // 
        // labelTo
        // 
        this.labelTo.AutoSize = true;
        this.labelTo.Location = new System.Drawing.Point(20, 221);
        this.labelTo.Name = "labelTo";
        this.labelTo.Size = new System.Drawing.Size(25, 15);
        this.labelTo.TabIndex = 11;
        this.labelTo.Text = "По:";
        // 
        // dtpFrom
        // 
        this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFrom.Location = new System.Drawing.Point(100, 187);
        this.dtpFrom.Name = "dtpFrom";
        this.dtpFrom.Size = new System.Drawing.Size(145, 23);
        this.dtpFrom.TabIndex = 10;
        // 
        // labelFrom
        // 
        this.labelFrom.AutoSize = true;
        this.labelFrom.Location = new System.Drawing.Point(20, 191);
        this.labelFrom.Name = "labelFrom";
        this.labelFrom.Size = new System.Drawing.Size(55, 15);
        this.labelFrom.TabIndex = 9;
        this.labelFrom.Text = "Дата з:";
        // 
        // btnSearch
        // 
        this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSearch.Location = new System.Drawing.Point(365, 143);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(110, 25);
        this.btnSearch.TabIndex = 8;
        this.btnSearch.Text = "Пошук";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        // 
        // txtSearch
        // 
        this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSearch.Location = new System.Drawing.Point(100, 145);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(251, 23);
        this.txtSearch.TabIndex = 7;
        // 
        // labelSearch
        // 
        this.labelSearch.AutoSize = true;
        this.labelSearch.Location = new System.Drawing.Point(20, 148);
        this.labelSearch.Name = "labelSearch";
        this.labelSearch.Size = new System.Drawing.Size(44, 15);
        this.labelSearch.TabIndex = 6;
        this.labelSearch.Text = "Запит:";
        // 
        // btnSentGroup
        // 
        this.btnSentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSentGroup.Location = new System.Drawing.Point(255, 105);
        this.btnSentGroup.Name = "btnSentGroup";
        this.btnSentGroup.Size = new System.Drawing.Size(220, 25);
        this.btnSentGroup.TabIndex = 5;
        this.btnSentGroup.Text = "Надіслані згруповані";
        this.btnSentGroup.UseVisualStyleBackColor = true;
        this.btnSentGroup.Click += new System.EventHandler(this.btnSentGroup_Click);
        // 
        // btnInboxGroup
        // 
        this.btnInboxGroup.Location = new System.Drawing.Point(20, 105);
        this.btnInboxGroup.Name = "btnInboxGroup";
        this.btnInboxGroup.Size = new System.Drawing.Size(220, 25);
        this.btnInboxGroup.TabIndex = 4;
        this.btnInboxGroup.Text = "Вхідні згруповані";
        this.btnInboxGroup.UseVisualStyleBackColor = true;
        this.btnInboxGroup.Click += new System.EventHandler(this.btnInboxGroup_Click);
        // 
        // btnSent
        // 
        this.btnSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSent.Location = new System.Drawing.Point(255, 70);
        this.btnSent.Name = "btnSent";
        this.btnSent.Size = new System.Drawing.Size(220, 25);
        this.btnSent.TabIndex = 3;
        this.btnSent.Text = "Надіслані";
        this.btnSent.UseVisualStyleBackColor = true;
        this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
        // 
        // btnInbox
        // 
        this.btnInbox.Location = new System.Drawing.Point(20, 70);
        this.btnInbox.Name = "btnInbox";
        this.btnInbox.Size = new System.Drawing.Size(220, 25);
        this.btnInbox.TabIndex = 2;
        this.btnInbox.Text = "Вхідні";
        this.btnInbox.UseVisualStyleBackColor = true;
        this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
        // 
        // labelSort
        // 
        this.labelSort.AutoSize = true;
        this.labelSort.Location = new System.Drawing.Point(20, 30);
        this.labelSort.Name = "labelSort";
        this.labelSort.Size = new System.Drawing.Size(97, 15);
        this.labelSort.TabIndex = 1;
        this.labelSort.Text = "Порядок сортування:";
        // 
        // cmbSortOrder
        // 
        this.cmbSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSortOrder.FormattingEnabled = true;
        this.cmbSortOrder.Location = new System.Drawing.Point(125, 27);
        this.cmbSortOrder.Name = "cmbSortOrder";
        this.cmbSortOrder.Size = new System.Drawing.Size(350, 23);
        this.cmbSortOrder.TabIndex = 0;
        // 
        // gbResults
        // 
        this.gbResults.Controls.Add(this.txtDetails);
        this.gbResults.Controls.Add(this.lvMessages);
        this.gbResults.Controls.Add(this.lblResultsHeader);
        this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbResults.Location = new System.Drawing.Point(500, 70);
        this.gbResults.Name = "gbResults";
        this.gbResults.Padding = new System.Windows.Forms.Padding(10);
        this.gbResults.Size = new System.Drawing.Size(484, 631);
        this.gbResults.TabIndex = 2;
        this.gbResults.TabStop = false;
        this.gbResults.Text = "Результати";
        // 
        // txtDetails
        // 
        this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtDetails.Location = new System.Drawing.Point(15, 490);
        this.txtDetails.Multiline = true;
        this.txtDetails.Name = "txtDetails";
        this.txtDetails.ReadOnly = true;
        this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtDetails.Size = new System.Drawing.Size(454, 130);
        this.txtDetails.TabIndex = 2;
        // 
        // lvMessages
        // 
        this.lvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.lvMessages.HideSelection = false;
        this.lvMessages.Location = new System.Drawing.Point(15, 40);
        this.lvMessages.Name = "lvMessages";
        this.lvMessages.Size = new System.Drawing.Size(454, 440);
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
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(984, 701);
        this.Controls.Add(this.gbResults);
        this.Controls.Add(this.gbActions);
        this.Controls.Add(this.pnlHeader);
        this.MinimumSize = new System.Drawing.Size(1000, 740);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "MessagingApp — Повідомлення";
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.gbActions.ResumeLayout(false);
        this.gbActions.PerformLayout();
        this.gbResults.ResumeLayout(false);
        this.gbResults.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
