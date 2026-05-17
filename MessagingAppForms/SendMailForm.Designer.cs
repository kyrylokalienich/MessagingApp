namespace MessagingAppForms;

partial class SendMailForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.GroupBox gbCompose;
    private System.Windows.Forms.Label labelRecipient;
    private System.Windows.Forms.TextBox txtRecipient;
    private System.Windows.Forms.Label labelSubject;
    private System.Windows.Forms.TextBox txtSubject;
    private System.Windows.Forms.Label labelBody;
    private System.Windows.Forms.TextBox txtBody;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.Button btnClose;
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
        this.gbCompose = new System.Windows.Forms.GroupBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();
        this.btnSend = new System.Windows.Forms.Button();
        this.txtBody = new System.Windows.Forms.TextBox();
        this.labelBody = new System.Windows.Forms.Label();
        this.txtSubject = new System.Windows.Forms.TextBox();
        this.labelSubject = new System.Windows.Forms.Label();
        this.txtRecipient = new System.Windows.Forms.TextBox();
        this.labelRecipient = new System.Windows.Forms.Label();
        this.gbCompose.SuspendLayout();
        this.SuspendLayout();
        // 
        // gbCompose
        // 
        this.gbCompose.Controls.Add(this.lblStatus);
        this.gbCompose.Controls.Add(this.btnClose);
        this.gbCompose.Controls.Add(this.btnSend);
        this.gbCompose.Controls.Add(this.txtBody);
        this.gbCompose.Controls.Add(this.labelBody);
        this.gbCompose.Controls.Add(this.txtSubject);
        this.gbCompose.Controls.Add(this.labelSubject);
        this.gbCompose.Controls.Add(this.txtRecipient);
        this.gbCompose.Controls.Add(this.labelRecipient);
        this.gbCompose.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gbCompose.Location = new System.Drawing.Point(0, 0);
        this.gbCompose.Name = "gbCompose";
        this.gbCompose.Padding = new System.Windows.Forms.Padding(15);
        this.gbCompose.Size = new System.Drawing.Size(484, 301);
        this.gbCompose.TabIndex = 0;
        this.gbCompose.TabStop = false;
        this.gbCompose.Text = "Надіслати повідомлення";
        // 
        // lblStatus
        // 
        this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.lblStatus.Location = new System.Drawing.Point(18, 235);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(448, 15);
        this.lblStatus.TabIndex = 8;
        // 
        // btnClose
        // 
        this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnClose.Location = new System.Drawing.Point(241, 263);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(110, 25);
        this.btnClose.TabIndex = 7;
        this.btnClose.Text = "Закрити";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // btnSend
        // 
        this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSend.Location = new System.Drawing.Point(357, 263);
        this.btnSend.Name = "btnSend";
        this.btnSend.Size = new System.Drawing.Size(110, 25);
        this.btnSend.TabIndex = 6;
        this.btnSend.Text = "Надіслати";
        this.btnSend.UseVisualStyleBackColor = true;
        this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
        // 
        // txtBody
        // 
        this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtBody.Location = new System.Drawing.Point(83, 95);
        this.txtBody.Multiline = true;
        this.txtBody.Name = "txtBody";
        this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtBody.Size = new System.Drawing.Size(383, 130);
        this.txtBody.TabIndex = 5;
        // 
        // labelBody
        // 
        this.labelBody.AutoSize = true;
        this.labelBody.Location = new System.Drawing.Point(18, 98);
        this.labelBody.Name = "labelBody";
        this.labelBody.Size = new System.Drawing.Size(35, 15);
        this.labelBody.TabIndex = 4;
        this.labelBody.Text = "Текст:";
        // 
        // txtSubject
        // 
        this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSubject.Location = new System.Drawing.Point(83, 63);
        this.txtSubject.Name = "txtSubject";
        this.txtSubject.Size = new System.Drawing.Size(383, 23);
        this.txtSubject.TabIndex = 3;
        // 
        // labelSubject
        // 
        this.labelSubject.AutoSize = true;
        this.labelSubject.Location = new System.Drawing.Point(18, 66);
        this.labelSubject.Name = "labelSubject";
        this.labelSubject.Size = new System.Drawing.Size(44, 15);
        this.labelSubject.TabIndex = 2;
        this.labelSubject.Text = "Тема:";
        // 
        // txtRecipient
        // 
        this.txtRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtRecipient.Location = new System.Drawing.Point(83, 31);
        this.txtRecipient.Name = "txtRecipient";
        this.txtRecipient.Size = new System.Drawing.Size(383, 23);
        this.txtRecipient.TabIndex = 1;
        // 
        // labelRecipient
        // 
        this.labelRecipient.AutoSize = true;
        this.labelRecipient.Location = new System.Drawing.Point(18, 34);
        this.labelRecipient.Name = "labelRecipient";
        this.labelRecipient.Size = new System.Drawing.Size(64, 15);
        this.labelRecipient.TabIndex = 0;
        this.labelRecipient.Text = "До (email):";
        // 
        // SendMailForm
        // 
        this.AcceptButton = this.btnSend;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btnClose;
        this.ClientSize = new System.Drawing.Size(484, 301);
        this.Controls.Add(this.gbCompose);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "SendMailForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "MessagingApp — Новий лист";
        this.gbCompose.ResumeLayout(false);
        this.gbCompose.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
