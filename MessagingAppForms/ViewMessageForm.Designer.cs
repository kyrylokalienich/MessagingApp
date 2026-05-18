namespace MessagingAppForms;

partial class ViewMessageForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.GroupBox gbMessage;
    private System.Windows.Forms.Label labelId;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label labelSender;
    private System.Windows.Forms.TextBox txtSender;
    private System.Windows.Forms.Label labelRecipient;
    private System.Windows.Forms.TextBox txtRecipient;
    private System.Windows.Forms.Label labelSubject;
    private System.Windows.Forms.TextBox txtSubject;
    private System.Windows.Forms.Label labelSentAt;
    private System.Windows.Forms.TextBox txtSentAt;
    private System.Windows.Forms.Label labelSize;
    private System.Windows.Forms.TextBox txtSize;
    private System.Windows.Forms.Label labelBody;
    private System.Windows.Forms.TextBox txtBody;
    private System.Windows.Forms.Button btnClose;

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
        this.gbMessage = new System.Windows.Forms.GroupBox();
        this.btnClose = new System.Windows.Forms.Button();
        this.txtBody = new System.Windows.Forms.TextBox();
        this.labelBody = new System.Windows.Forms.Label();
        this.txtSize = new System.Windows.Forms.TextBox();
        this.labelSize = new System.Windows.Forms.Label();
        this.txtSentAt = new System.Windows.Forms.TextBox();
        this.labelSentAt = new System.Windows.Forms.Label();
        this.txtSubject = new System.Windows.Forms.TextBox();
        this.labelSubject = new System.Windows.Forms.Label();
        this.txtRecipient = new System.Windows.Forms.TextBox();
        this.labelRecipient = new System.Windows.Forms.Label();
        this.txtSender = new System.Windows.Forms.TextBox();
        this.labelSender = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.labelId = new System.Windows.Forms.Label();
        this.gbMessage.SuspendLayout();
        this.SuspendLayout();
        // 
        // gbMessage
        // 
        this.gbMessage.Controls.Add(this.btnClose);
        this.gbMessage.Controls.Add(this.txtBody);
        this.gbMessage.Controls.Add(this.labelBody);
        this.gbMessage.Controls.Add(this.txtSize);
        this.gbMessage.Controls.Add(this.labelSize);
        this.gbMessage.Controls.Add(this.txtSentAt);
        this.gbMessage.Controls.Add(this.labelSentAt);
        this.gbMessage.Controls.Add(this.txtSubject);
        this.gbMessage.Controls.Add(this.labelSubject);
        this.gbMessage.Controls.Add(this.txtRecipient);
        this.gbMessage.Controls.Add(this.labelRecipient);
        this.gbMessage.Controls.Add(this.txtSender);
        this.gbMessage.Controls.Add(this.labelSender);
        this.gbMessage.Controls.Add(this.txtId);
        this.gbMessage.Controls.Add(this.labelId);
        this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbMessage.Location = new System.Drawing.Point(0, 0);
        this.gbMessage.Name = "gbMessage";
        this.gbMessage.Padding = new System.Windows.Forms.Padding(15);
        this.gbMessage.Size = new System.Drawing.Size(584, 441);
        this.gbMessage.TabIndex = 0;
        this.gbMessage.TabStop = false;
        this.gbMessage.Text = "Повне повідомлення";
        // 
        // btnClose
        // 
        this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnClose.Location = new System.Drawing.Point(457, 403);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(110, 25);
        this.btnClose.TabIndex = 14;
        this.btnClose.Text = "Закрити";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // txtId
        // 
        this.txtId.Location = new System.Drawing.Point(83, 28);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(120, 23);
        this.txtId.TabIndex = 1;
        // 
        // labelId
        // 
        this.labelId.AutoSize = true;
        this.labelId.Location = new System.Drawing.Point(18, 31);
        this.labelId.Name = "labelId";
        this.labelId.Size = new System.Drawing.Size(21, 15);
        this.labelId.TabIndex = 0;
        this.labelId.Text = "ID:";
        // 
        // txtBody
        // 
        this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtBody.Location = new System.Drawing.Point(83, 223);
        this.txtBody.Multiline = true;
        this.txtBody.Name = "txtBody";
        this.txtBody.ReadOnly = true;
        this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtBody.Size = new System.Drawing.Size(484, 168);
        this.txtBody.TabIndex = 13;
        this.txtBody.WordWrap = false;
        // 
        // labelBody
        // 
        this.labelBody.AutoSize = true;
        this.labelBody.Location = new System.Drawing.Point(18, 226);
        this.labelBody.Name = "labelBody";
        this.labelBody.Size = new System.Drawing.Size(35, 15);
        this.labelBody.TabIndex = 12;
        this.labelBody.Text = "Текст:";
        // 
        // txtSize
        // 
        this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSize.Location = new System.Drawing.Point(83, 191);
        this.txtSize.Name = "txtSize";
        this.txtSize.ReadOnly = true;
        this.txtSize.Size = new System.Drawing.Size(484, 23);
        this.txtSize.TabIndex = 11;
        // 
        // labelSize
        // 
        this.labelSize.AutoSize = true;
        this.labelSize.Location = new System.Drawing.Point(18, 194);
        this.labelSize.Name = "labelSize";
        this.labelSize.Size = new System.Drawing.Size(44, 15);
        this.labelSize.TabIndex = 10;
        this.labelSize.Text = "Розмір:";
        // 
        // txtSentAt
        // 
        this.txtSentAt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSentAt.Location = new System.Drawing.Point(83, 159);
        this.txtSentAt.Name = "txtSentAt";
        this.txtSentAt.ReadOnly = true;
        this.txtSentAt.Size = new System.Drawing.Size(484, 23);
        this.txtSentAt.TabIndex = 9;
        // 
        // labelSentAt
        // 
        this.labelSentAt.AutoSize = true;
        this.labelSentAt.Location = new System.Drawing.Point(18, 162);
        this.labelSentAt.Name = "labelSentAt";
        this.labelSentAt.Size = new System.Drawing.Size(37, 15);
        this.labelSentAt.TabIndex = 8;
        this.labelSentAt.Text = "Дата:";
        // 
        // txtSubject
        // 
        this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSubject.Location = new System.Drawing.Point(83, 127);
        this.txtSubject.Name = "txtSubject";
        this.txtSubject.ReadOnly = true;
        this.txtSubject.Size = new System.Drawing.Size(484, 23);
        this.txtSubject.TabIndex = 7;
        // 
        // labelSubject
        // 
        this.labelSubject.AutoSize = true;
        this.labelSubject.Location = new System.Drawing.Point(18, 130);
        this.labelSubject.Name = "labelSubject";
        this.labelSubject.Size = new System.Drawing.Size(44, 15);
        this.labelSubject.TabIndex = 6;
        this.labelSubject.Text = "Тема:";
        // 
        // txtRecipient
        // 
        this.txtRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtRecipient.Location = new System.Drawing.Point(83, 95);
        this.txtRecipient.Name = "txtRecipient";
        this.txtRecipient.ReadOnly = true;
        this.txtRecipient.Size = new System.Drawing.Size(484, 23);
        this.txtRecipient.TabIndex = 5;
        // 
        // labelRecipient
        // 
        this.labelRecipient.AutoSize = true;
        this.labelRecipient.Location = new System.Drawing.Point(18, 98);
        this.labelRecipient.Name = "labelRecipient";
        this.labelRecipient.Size = new System.Drawing.Size(25, 15);
        this.labelRecipient.TabIndex = 4;
        this.labelRecipient.Text = "До:";
        // 
        // txtSender
        // 
        this.txtSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSender.Location = new System.Drawing.Point(83, 63);
        this.txtSender.Name = "txtSender";
        this.txtSender.ReadOnly = true;
        this.txtSender.Size = new System.Drawing.Size(484, 23);
        this.txtSender.TabIndex = 3;
        // 
        // labelSender
        // 
        this.labelSender.AutoSize = true;
        this.labelSender.Location = new System.Drawing.Point(18, 66);
        this.labelSender.Name = "labelSender";
        this.labelSender.Size = new System.Drawing.Size(25, 15);
        this.labelSender.TabIndex = 2;
        this.labelSender.Text = "Від:";
        // 
        // ViewMessageForm
        // 
        this.AcceptButton = this.btnClose;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btnClose;
        this.ClientSize = new System.Drawing.Size(584, 441);
        this.Controls.Add(this.gbMessage);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        this.MinimumSize = new System.Drawing.Size(600, 480);
        this.Name = "ViewMessageForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Повідомлення";
        this.gbMessage.ResumeLayout(false);
        this.gbMessage.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
