namespace UIForms {
    partial class AccountSettingsF {
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
            this.ctrlSave = new System.Windows.Forms.Button();
            this.loServerAddress = new System.Windows.Forms.Label();
            this.loServerPort = new System.Windows.Forms.Label();
            this.loUsername = new System.Windows.Forms.Label();
            this.loPassword = new System.Windows.Forms.Label();
            this.loUseSSL = new System.Windows.Forms.Label();
            this.ctrlPOP3ServerAddress = new System.Windows.Forms.TextBox();
            this.ctrlPOP3Password = new System.Windows.Forms.TextBox();
            this.ctrlPOP3Username = new System.Windows.Forms.TextBox();
            this.ctrlPOP3ServerPort = new System.Windows.Forms.TextBox();
            this.ctrlPOP3UseSSL = new System.Windows.Forms.CheckBox();
            this.loSMTPServerAddress = new System.Windows.Forms.Label();
            this.loSMTPServerPort = new System.Windows.Forms.Label();
            this.loSMTPUsername = new System.Windows.Forms.Label();
            this.loSMTPPassword = new System.Windows.Forms.Label();
            this.loSMTPUseSSL = new System.Windows.Forms.Label();
            this.ctrlSMTPServerAddress = new System.Windows.Forms.TextBox();
            this.ctrlSMTPServerPort = new System.Windows.Forms.TextBox();
            this.ctrlSMTPUsername = new System.Windows.Forms.TextBox();
            this.ctrlSMTPPassword = new System.Windows.Forms.TextBox();
            this.ctrlSMTPUseSSL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(683, 398);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(75, 23);
            this.ctrlSave.TabIndex = 0;
            this.ctrlSave.Text = "Save";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // loServerAddress
            // 
            this.loServerAddress.AutoSize = true;
            this.loServerAddress.Location = new System.Drawing.Point(12, 31);
            this.loServerAddress.Name = "loServerAddress";
            this.loServerAddress.Size = new System.Drawing.Size(107, 13);
            this.loServerAddress.TabIndex = 1;
            this.loServerAddress.Text = "Pop3 Server Address";
            // 
            // loServerPort
            // 
            this.loServerPort.AutoSize = true;
            this.loServerPort.Location = new System.Drawing.Point(12, 57);
            this.loServerPort.Name = "loServerPort";
            this.loServerPort.Size = new System.Drawing.Size(88, 13);
            this.loServerPort.TabIndex = 2;
            this.loServerPort.Text = "Pop3 Server Port";
            // 
            // loUsername
            // 
            this.loUsername.AutoSize = true;
            this.loUsername.Location = new System.Drawing.Point(12, 83);
            this.loUsername.Name = "loUsername";
            this.loUsername.Size = new System.Drawing.Size(55, 13);
            this.loUsername.TabIndex = 3;
            this.loUsername.Text = "Username";
            // 
            // loPassword
            // 
            this.loPassword.AutoSize = true;
            this.loPassword.Location = new System.Drawing.Point(12, 109);
            this.loPassword.Name = "loPassword";
            this.loPassword.Size = new System.Drawing.Size(53, 13);
            this.loPassword.TabIndex = 4;
            this.loPassword.Text = "Password";
            // 
            // loUseSSL
            // 
            this.loUseSSL.AutoSize = true;
            this.loUseSSL.Location = new System.Drawing.Point(12, 138);
            this.loUseSSL.Name = "loUseSSL";
            this.loUseSSL.Size = new System.Drawing.Size(49, 13);
            this.loUseSSL.TabIndex = 5;
            this.loUseSSL.Text = "Use SSL";
            // 
            // ctrlPOP3ServerAddress
            // 
            this.ctrlPOP3ServerAddress.Location = new System.Drawing.Point(120, 31);
            this.ctrlPOP3ServerAddress.Name = "ctrlPOP3ServerAddress";
            this.ctrlPOP3ServerAddress.Size = new System.Drawing.Size(190, 20);
            this.ctrlPOP3ServerAddress.TabIndex = 6;
            // 
            // ctrlPOP3Password
            // 
            this.ctrlPOP3Password.Location = new System.Drawing.Point(120, 109);
            this.ctrlPOP3Password.Name = "ctrlPOP3Password";
            this.ctrlPOP3Password.Size = new System.Drawing.Size(190, 20);
            this.ctrlPOP3Password.TabIndex = 7;
            // 
            // ctrlPOP3Username
            // 
            this.ctrlPOP3Username.Location = new System.Drawing.Point(120, 83);
            this.ctrlPOP3Username.Name = "ctrlPOP3Username";
            this.ctrlPOP3Username.Size = new System.Drawing.Size(190, 20);
            this.ctrlPOP3Username.TabIndex = 8;
            // 
            // ctrlPOP3ServerPort
            // 
            this.ctrlPOP3ServerPort.Location = new System.Drawing.Point(120, 57);
            this.ctrlPOP3ServerPort.Name = "ctrlPOP3ServerPort";
            this.ctrlPOP3ServerPort.Size = new System.Drawing.Size(190, 20);
            this.ctrlPOP3ServerPort.TabIndex = 9;
            // 
            // ctrlPOP3UseSSL
            // 
            this.ctrlPOP3UseSSL.AutoSize = true;
            this.ctrlPOP3UseSSL.Location = new System.Drawing.Point(120, 135);
            this.ctrlPOP3UseSSL.Name = "ctrlPOP3UseSSL";
            this.ctrlPOP3UseSSL.Size = new System.Drawing.Size(15, 14);
            this.ctrlPOP3UseSSL.TabIndex = 10;
            this.ctrlPOP3UseSSL.UseVisualStyleBackColor = true;
            // 
            // loSMTPServerAddress
            // 
            this.loSMTPServerAddress.AutoSize = true;
            this.loSMTPServerAddress.Location = new System.Drawing.Point(350, 31);
            this.loSMTPServerAddress.Name = "loSMTPServerAddress";
            this.loSMTPServerAddress.Size = new System.Drawing.Size(112, 13);
            this.loSMTPServerAddress.TabIndex = 11;
            this.loSMTPServerAddress.Text = "SMTP Server Address";
            // 
            // loSMTPServerPort
            // 
            this.loSMTPServerPort.AutoSize = true;
            this.loSMTPServerPort.Location = new System.Drawing.Point(350, 57);
            this.loSMTPServerPort.Name = "loSMTPServerPort";
            this.loSMTPServerPort.Size = new System.Drawing.Size(93, 13);
            this.loSMTPServerPort.TabIndex = 12;
            this.loSMTPServerPort.Text = "SMTP Server Port";
            // 
            // loSMTPUsername
            // 
            this.loSMTPUsername.AutoSize = true;
            this.loSMTPUsername.Location = new System.Drawing.Point(350, 83);
            this.loSMTPUsername.Name = "loSMTPUsername";
            this.loSMTPUsername.Size = new System.Drawing.Size(55, 13);
            this.loSMTPUsername.TabIndex = 13;
            this.loSMTPUsername.Text = "Username";
            // 
            // loSMTPPassword
            // 
            this.loSMTPPassword.AutoSize = true;
            this.loSMTPPassword.Location = new System.Drawing.Point(350, 112);
            this.loSMTPPassword.Name = "loSMTPPassword";
            this.loSMTPPassword.Size = new System.Drawing.Size(53, 13);
            this.loSMTPPassword.TabIndex = 14;
            this.loSMTPPassword.Text = "Password";
            // 
            // loSMTPUseSSL
            // 
            this.loSMTPUseSSL.AutoSize = true;
            this.loSMTPUseSSL.Location = new System.Drawing.Point(350, 138);
            this.loSMTPUseSSL.Name = "loSMTPUseSSL";
            this.loSMTPUseSSL.Size = new System.Drawing.Size(49, 13);
            this.loSMTPUseSSL.TabIndex = 15;
            this.loSMTPUseSSL.Text = "Use SSL";
            // 
            // ctrlSMTPServerAddress
            // 
            this.ctrlSMTPServerAddress.Location = new System.Drawing.Point(472, 31);
            this.ctrlSMTPServerAddress.Name = "ctrlSMTPServerAddress";
            this.ctrlSMTPServerAddress.Size = new System.Drawing.Size(190, 20);
            this.ctrlSMTPServerAddress.TabIndex = 16;
            // 
            // ctrlSMTPServerPort
            // 
            this.ctrlSMTPServerPort.Location = new System.Drawing.Point(472, 57);
            this.ctrlSMTPServerPort.Name = "ctrlSMTPServerPort";
            this.ctrlSMTPServerPort.Size = new System.Drawing.Size(190, 20);
            this.ctrlSMTPServerPort.TabIndex = 17;
            // 
            // ctrlSMTPUsername
            // 
            this.ctrlSMTPUsername.Location = new System.Drawing.Point(472, 83);
            this.ctrlSMTPUsername.Name = "ctrlSMTPUsername";
            this.ctrlSMTPUsername.Size = new System.Drawing.Size(190, 20);
            this.ctrlSMTPUsername.TabIndex = 18;
            // 
            // ctrlSMTPPassword
            // 
            this.ctrlSMTPPassword.Location = new System.Drawing.Point(472, 109);
            this.ctrlSMTPPassword.Name = "ctrlSMTPPassword";
            this.ctrlSMTPPassword.Size = new System.Drawing.Size(190, 20);
            this.ctrlSMTPPassword.TabIndex = 19;
            // 
            // ctrlSMTPUseSSL
            // 
            this.ctrlSMTPUseSSL.AutoSize = true;
            this.ctrlSMTPUseSSL.Location = new System.Drawing.Point(472, 135);
            this.ctrlSMTPUseSSL.Name = "ctrlSMTPUseSSL";
            this.ctrlSMTPUseSSL.Size = new System.Drawing.Size(15, 14);
            this.ctrlSMTPUseSSL.TabIndex = 20;
            this.ctrlSMTPUseSSL.UseVisualStyleBackColor = true;
            // 
            // AccountSettingsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlSMTPUseSSL);
            this.Controls.Add(this.ctrlSMTPPassword);
            this.Controls.Add(this.ctrlSMTPUsername);
            this.Controls.Add(this.ctrlSMTPServerPort);
            this.Controls.Add(this.ctrlSMTPServerAddress);
            this.Controls.Add(this.loSMTPUseSSL);
            this.Controls.Add(this.loSMTPPassword);
            this.Controls.Add(this.loSMTPUsername);
            this.Controls.Add(this.loSMTPServerPort);
            this.Controls.Add(this.loSMTPServerAddress);
            this.Controls.Add(this.ctrlPOP3UseSSL);
            this.Controls.Add(this.ctrlPOP3ServerPort);
            this.Controls.Add(this.ctrlPOP3Username);
            this.Controls.Add(this.ctrlPOP3Password);
            this.Controls.Add(this.ctrlPOP3ServerAddress);
            this.Controls.Add(this.loUseSSL);
            this.Controls.Add(this.loPassword);
            this.Controls.Add(this.loUsername);
            this.Controls.Add(this.loServerPort);
            this.Controls.Add(this.loServerAddress);
            this.Controls.Add(this.ctrlSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountSettingsF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Account Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Label loServerAddress;
        private System.Windows.Forms.Label loServerPort;
        private System.Windows.Forms.Label loUsername;
        private System.Windows.Forms.Label loPassword;
        private System.Windows.Forms.Label loUseSSL;
        private System.Windows.Forms.TextBox ctrlPOP3ServerAddress;
        private System.Windows.Forms.TextBox ctrlPOP3Password;
        private System.Windows.Forms.TextBox ctrlPOP3Username;
        private System.Windows.Forms.TextBox ctrlPOP3ServerPort;
        private System.Windows.Forms.CheckBox ctrlPOP3UseSSL;
        private System.Windows.Forms.Label loSMTPServerAddress;
        private System.Windows.Forms.Label loSMTPServerPort;
        private System.Windows.Forms.Label loSMTPUsername;
        private System.Windows.Forms.Label loSMTPPassword;
        private System.Windows.Forms.Label loSMTPUseSSL;
        private System.Windows.Forms.TextBox ctrlSMTPServerAddress;
        private System.Windows.Forms.TextBox ctrlSMTPServerPort;
        private System.Windows.Forms.TextBox ctrlSMTPUsername;
        private System.Windows.Forms.TextBox ctrlSMTPPassword;
        private System.Windows.Forms.CheckBox ctrlSMTPUseSSL;
    }
}