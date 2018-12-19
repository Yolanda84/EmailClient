namespace UIForms {
    partial class MainF {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceiveEmails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctrlEmailBody = new System.Windows.Forms.RichTextBox();
            this.ctrlProgressBar = new System.Windows.Forms.ProgressBar();
            this.loEmailNumber = new System.Windows.Forms.Label();
            this.loEmailCounter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loReadEmails = new System.Windows.Forms.Label();
            this.loReadEmailsCounter = new System.Windows.Forms.Label();
            this.loSentEmails = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmail,
            this.menuSettings,
            this.menuGeneral});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEmail
            // 
            this.menuEmail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewEmail,
            this.menuReceiveEmails,
            this.menuExit});
            this.menuEmail.Name = "menuEmail";
            this.menuEmail.Size = new System.Drawing.Size(91, 20);
            this.menuEmail.Text = "Email Actions";
            this.menuEmail.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // menuNewEmail
            // 
            this.menuNewEmail.Name = "menuNewEmail";
            this.menuNewEmail.Size = new System.Drawing.Size(151, 22);
            this.menuNewEmail.Text = "New Email";
            this.menuNewEmail.Click += new System.EventHandler(this.menuNewEmail_Click);
            // 
            // menuReceiveEmails
            // 
            this.menuReceiveEmails.Name = "menuReceiveEmails";
            this.menuReceiveEmails.Size = new System.Drawing.Size(151, 22);
            this.menuReceiveEmails.Text = "Receive Emails";
            this.menuReceiveEmails.Click += new System.EventHandler(this.ctrlReceiveEmails_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(151, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(61, 20);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuGeneral
            // 
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(59, 20);
            this.menuGeneral.Text = "General";
            this.menuGeneral.Click += new System.EventHandler(this.menuGeneral_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1359, 438);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1351, 412);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1345, 406);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctrlEmailBody);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1351, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrlEmailBody
            // 
            this.ctrlEmailBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlEmailBody.Location = new System.Drawing.Point(3, 3);
            this.ctrlEmailBody.Name = "ctrlEmailBody";
            this.ctrlEmailBody.Size = new System.Drawing.Size(1345, 406);
            this.ctrlEmailBody.TabIndex = 9;
            this.ctrlEmailBody.Text = "";
            // 
            // ctrlProgressBar
            // 
            this.ctrlProgressBar.Location = new System.Drawing.Point(1001, 722);
            this.ctrlProgressBar.Name = "ctrlProgressBar";
            this.ctrlProgressBar.Size = new System.Drawing.Size(358, 18);
            this.ctrlProgressBar.TabIndex = 1;
            // 
            // loEmailNumber
            // 
            this.loEmailNumber.AutoSize = true;
            this.loEmailNumber.BackColor = System.Drawing.Color.Transparent;
            this.loEmailNumber.Location = new System.Drawing.Point(1180, 724);
            this.loEmailNumber.Name = "loEmailNumber";
            this.loEmailNumber.Size = new System.Drawing.Size(36, 13);
            this.loEmailNumber.TabIndex = 11;
            this.loEmailNumber.Text = "0/100";
            // 
            // loEmailCounter
            // 
            this.loEmailCounter.AutoSize = true;
            this.loEmailCounter.BackColor = System.Drawing.SystemColors.Control;
            this.loEmailCounter.Location = new System.Drawing.Point(1317, 724);
            this.loEmailCounter.Name = "loEmailCounter";
            this.loEmailCounter.Size = new System.Drawing.Size(35, 13);
            this.loEmailCounter.TabIndex = 12;
            this.loEmailCounter.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colSender,
            this.colSubject,
            this.colDate,
            this.colRead});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1359, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colSender
            // 
            this.colSender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSender.HeaderText = "Sender";
            this.colSender.Name = "colSender";
            this.colSender.ReadOnly = true;
            // 
            // colSubject
            // 
            this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colRead
            // 
            this.colRead.HeaderText = "Read";
            this.colRead.Name = "colRead";
            this.colRead.ReadOnly = true;
            this.colRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // loReadEmails
            // 
            this.loReadEmails.AutoSize = true;
            this.loReadEmails.Location = new System.Drawing.Point(857, 727);
            this.loReadEmails.Name = "loReadEmails";
            this.loReadEmails.Size = new System.Drawing.Size(66, 13);
            this.loReadEmails.TabIndex = 13;
            this.loReadEmails.Text = "Read Emails";
            // 
            // loReadEmailsCounter
            // 
            this.loReadEmailsCounter.AutoSize = true;
            this.loReadEmailsCounter.Location = new System.Drawing.Point(944, 726);
            this.loReadEmailsCounter.Name = "loReadEmailsCounter";
            this.loReadEmailsCounter.Size = new System.Drawing.Size(35, 13);
            this.loReadEmailsCounter.TabIndex = 14;
            this.loReadEmailsCounter.Text = "label1";
            // 
            // loSentEmails
            // 
            this.loSentEmails.AutoSize = true;
            this.loSentEmails.Location = new System.Drawing.Point(679, 726);
            this.loSentEmails.Name = "loSentEmails";
            this.loSentEmails.Size = new System.Drawing.Size(62, 13);
            this.loSentEmails.TabIndex = 15;
            this.loSentEmails.Text = "Sent Emails";
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 746);
            this.Controls.Add(this.loSentEmails);
            this.Controls.Add(this.loReadEmailsCounter);
            this.Controls.Add(this.loReadEmails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loEmailCounter);
            this.Controls.Add(this.loEmailNumber);
            this.Controls.Add(this.ctrlProgressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My email";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEmail;
        private System.Windows.Forms.ToolStripMenuItem menuNewEmail;
        private System.Windows.Forms.ToolStripMenuItem menuReceiveEmails;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuGeneral;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox ctrlEmailBody;
        private System.Windows.Forms.ProgressBar ctrlProgressBar;
        private System.Windows.Forms.Label loEmailNumber;
        private System.Windows.Forms.Label loEmailCounter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label loReadEmails;
        private System.Windows.Forms.Label loReadEmailsCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRead;
        private System.Windows.Forms.Label loSentEmails;
    }
}

