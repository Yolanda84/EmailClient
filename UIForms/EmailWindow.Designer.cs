namespace UIForms {
    partial class EmailWindowF {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.loTo = new System.Windows.Forms.Label();
            this.loCC = new System.Windows.Forms.Label();
            this.loSubject = new System.Windows.Forms.Label();
            this.loBCC = new System.Windows.Forms.Label();
            this.ctrlTo = new System.Windows.Forms.TextBox();
            this.ctrlBCC = new System.Windows.Forms.TextBox();
            this.ctrlCC = new System.Windows.Forms.TextBox();
            this.ctrlSubject = new System.Windows.Forms.TextBox();
            this.ctrlSend = new System.Windows.Forms.Button();
            this.loFrom = new System.Windows.Forms.Label();
            this.ctrlFrom = new System.Windows.Forms.TextBox();
            this.loDate = new System.Windows.Forms.Label();
            this.ctrlDate = new System.Windows.Forms.DateTimePicker();
            this.ctrlHtmlWindowView = new System.Windows.Forms.TabControl();
            this.ctrlWindowEmailView = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ctrlAttachmentView = new System.Windows.Forms.TabPage();
            this.ctrlAttachementListbox = new System.Windows.Forms.ListBox();
            this.ctrlHtmlWindowView.SuspendLayout();
            this.ctrlWindowEmailView.SuspendLayout();
            this.ctrlAttachmentView.SuspendLayout();
            this.SuspendLayout();
            // 
            // loTo
            // 
            this.loTo.AutoSize = true;
            this.loTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loTo.Location = new System.Drawing.Point(1, 38);
            this.loTo.Name = "loTo";
            this.loTo.Size = new System.Drawing.Size(27, 15);
            this.loTo.TabIndex = 0;
            this.loTo.Text = "To:";
            // 
            // loCC
            // 
            this.loCC.AutoSize = true;
            this.loCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loCC.Location = new System.Drawing.Point(1, 96);
            this.loCC.Name = "loCC";
            this.loCC.Size = new System.Drawing.Size(29, 15);
            this.loCC.TabIndex = 1;
            this.loCC.Text = "CC:";
            // 
            // loSubject
            // 
            this.loSubject.AutoSize = true;
            this.loSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loSubject.Location = new System.Drawing.Point(1, 67);
            this.loSubject.Name = "loSubject";
            this.loSubject.Size = new System.Drawing.Size(59, 15);
            this.loSubject.TabIndex = 2;
            this.loSubject.Text = "Subject:";
            // 
            // loBCC
            // 
            this.loBCC.AutoSize = true;
            this.loBCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loBCC.Location = new System.Drawing.Point(1, 125);
            this.loBCC.Name = "loBCC";
            this.loBCC.Size = new System.Drawing.Size(38, 15);
            this.loBCC.TabIndex = 3;
            this.loBCC.Text = "BCC:";
            // 
            // ctrlTo
            // 
            this.ctrlTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTo.Location = new System.Drawing.Point(89, 38);
            this.ctrlTo.Name = "ctrlTo";
            this.ctrlTo.Size = new System.Drawing.Size(1174, 20);
            this.ctrlTo.TabIndex = 4;
            // 
            // ctrlBCC
            // 
            this.ctrlBCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBCC.Location = new System.Drawing.Point(89, 125);
            this.ctrlBCC.Name = "ctrlBCC";
            this.ctrlBCC.Size = new System.Drawing.Size(1174, 20);
            this.ctrlBCC.TabIndex = 5;
            // 
            // ctrlCC
            // 
            this.ctrlCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCC.Location = new System.Drawing.Point(89, 96);
            this.ctrlCC.Name = "ctrlCC";
            this.ctrlCC.Size = new System.Drawing.Size(1174, 20);
            this.ctrlCC.TabIndex = 6;
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlSubject.Location = new System.Drawing.Point(89, 67);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(1174, 20);
            this.ctrlSubject.TabIndex = 7;
            // 
            // ctrlSend
            // 
            this.ctrlSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSend.Location = new System.Drawing.Point(1188, 592);
            this.ctrlSend.Name = "ctrlSend";
            this.ctrlSend.Size = new System.Drawing.Size(75, 23);
            this.ctrlSend.TabIndex = 11;
            this.ctrlSend.Text = "Send";
            this.ctrlSend.UseVisualStyleBackColor = true;
            // 
            // loFrom
            // 
            this.loFrom.AutoSize = true;
            this.loFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loFrom.Location = new System.Drawing.Point(1, 9);
            this.loFrom.Name = "loFrom";
            this.loFrom.Size = new System.Drawing.Size(44, 15);
            this.loFrom.TabIndex = 12;
            this.loFrom.Text = "From:";
            // 
            // ctrlFrom
            // 
            this.ctrlFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFrom.Location = new System.Drawing.Point(89, 9);
            this.ctrlFrom.Name = "ctrlFrom";
            this.ctrlFrom.Size = new System.Drawing.Size(1174, 20);
            this.ctrlFrom.TabIndex = 13;
            // 
            // loDate
            // 
            this.loDate.AutoSize = true;
            this.loDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loDate.Location = new System.Drawing.Point(1003, 154);
            this.loDate.Name = "loDate";
            this.loDate.Size = new System.Drawing.Size(41, 15);
            this.loDate.TabIndex = 15;
            this.loDate.Text = "Date:";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Location = new System.Drawing.Point(1063, 154);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(200, 20);
            this.ctrlDate.TabIndex = 16;
            // 
            // ctrlHtmlWindowView
            // 
            this.ctrlHtmlWindowView.Controls.Add(this.ctrlWindowEmailView);
            this.ctrlHtmlWindowView.Controls.Add(this.ctrlAttachmentView);
            this.ctrlHtmlWindowView.Location = new System.Drawing.Point(4, 180);
            this.ctrlHtmlWindowView.Name = "ctrlHtmlWindowView";
            this.ctrlHtmlWindowView.SelectedIndex = 0;
            this.ctrlHtmlWindowView.Size = new System.Drawing.Size(1259, 435);
            this.ctrlHtmlWindowView.TabIndex = 18;
            // 
            // ctrlWindowEmailView
            // 
            this.ctrlWindowEmailView.Controls.Add(this.webBrowser1);
            this.ctrlWindowEmailView.Location = new System.Drawing.Point(4, 22);
            this.ctrlWindowEmailView.Name = "ctrlWindowEmailView";
            this.ctrlWindowEmailView.Padding = new System.Windows.Forms.Padding(3);
            this.ctrlWindowEmailView.Size = new System.Drawing.Size(1251, 409);
            this.ctrlWindowEmailView.TabIndex = 0;
            this.ctrlWindowEmailView.Text = "Email";
            this.ctrlWindowEmailView.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1245, 403);
            this.webBrowser1.TabIndex = 0;
            // 
            // ctrlAttachmentView
            // 
            this.ctrlAttachmentView.Controls.Add(this.ctrlAttachementListbox);
            this.ctrlAttachmentView.Location = new System.Drawing.Point(4, 22);
            this.ctrlAttachmentView.Name = "ctrlAttachmentView";
            this.ctrlAttachmentView.Padding = new System.Windows.Forms.Padding(3);
            this.ctrlAttachmentView.Size = new System.Drawing.Size(1251, 409);
            this.ctrlAttachmentView.TabIndex = 1;
            this.ctrlAttachmentView.Text = "Attachments";
            this.ctrlAttachmentView.UseVisualStyleBackColor = true;
            // 
            // ctrlAttachementListbox
            // 
            this.ctrlAttachementListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAttachementListbox.FormattingEnabled = true;
            this.ctrlAttachementListbox.Location = new System.Drawing.Point(3, 3);
            this.ctrlAttachementListbox.Name = "ctrlAttachementListbox";
            this.ctrlAttachementListbox.Size = new System.Drawing.Size(1245, 403);
            this.ctrlAttachementListbox.TabIndex = 0;
            this.ctrlAttachementListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctrlAttachementListbox_MouseDoubleClick);
            // 
            // EmailWindowF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 638);
            this.Controls.Add(this.ctrlHtmlWindowView);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.loDate);
            this.Controls.Add(this.ctrlFrom);
            this.Controls.Add(this.loFrom);
            this.Controls.Add(this.ctrlSend);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCC);
            this.Controls.Add(this.ctrlBCC);
            this.Controls.Add(this.ctrlTo);
            this.Controls.Add(this.loBCC);
            this.Controls.Add(this.loSubject);
            this.Controls.Add(this.loCC);
            this.Controls.Add(this.loTo);
            this.Name = "EmailWindowF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ctrlHtmlWindowView.ResumeLayout(false);
            this.ctrlWindowEmailView.ResumeLayout(false);
            this.ctrlAttachmentView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loTo;
        private System.Windows.Forms.Label loCC;
        private System.Windows.Forms.Label loSubject;
        private System.Windows.Forms.Label loBCC;
        private System.Windows.Forms.TextBox ctrlTo;
        private System.Windows.Forms.TextBox ctrlBCC;
        private System.Windows.Forms.TextBox ctrlCC;
        private System.Windows.Forms.TextBox ctrlSubject;
        private System.Windows.Forms.Button ctrlSend;
        private System.Windows.Forms.Label loFrom;
        private System.Windows.Forms.TextBox ctrlFrom;
        private System.Windows.Forms.Label loDate;
        private System.Windows.Forms.DateTimePicker ctrlDate;
        private System.Windows.Forms.TabControl ctrlHtmlWindowView;
        private System.Windows.Forms.TabPage ctrlWindowEmailView;
        private System.Windows.Forms.TabPage ctrlAttachmentView;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox ctrlAttachementListbox;
    }
}