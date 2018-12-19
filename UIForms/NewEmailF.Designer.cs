namespace UIForms {
    partial class NewEmailF {
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
            this.loFrom = new System.Windows.Forms.Label();
            this.ctrlFrom = new System.Windows.Forms.TextBox();
            this.ctrlEmailBody = new System.Windows.Forms.RichTextBox();
            this.ctrlSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loTo
            // 
            this.loTo.AutoSize = true;
            this.loTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loTo.Location = new System.Drawing.Point(0, 39);
            this.loTo.Name = "loTo";
            this.loTo.Size = new System.Drawing.Size(27, 15);
            this.loTo.TabIndex = 0;
            this.loTo.Text = "To:";
            // 
            // loCC
            // 
            this.loCC.AutoSize = true;
            this.loCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loCC.Location = new System.Drawing.Point(0, 97);
            this.loCC.Name = "loCC";
            this.loCC.Size = new System.Drawing.Size(29, 15);
            this.loCC.TabIndex = 1;
            this.loCC.Text = "CC:";
            // 
            // loSubject
            // 
            this.loSubject.AutoSize = true;
            this.loSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loSubject.Location = new System.Drawing.Point(0, 68);
            this.loSubject.Name = "loSubject";
            this.loSubject.Size = new System.Drawing.Size(59, 15);
            this.loSubject.TabIndex = 2;
            this.loSubject.Text = "Subject:";
            // 
            // loBCC
            // 
            this.loBCC.AutoSize = true;
            this.loBCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loBCC.Location = new System.Drawing.Point(0, 126);
            this.loBCC.Name = "loBCC";
            this.loBCC.Size = new System.Drawing.Size(38, 15);
            this.loBCC.TabIndex = 3;
            this.loBCC.Text = "BCC:";
            // 
            // ctrlTo
            // 
            this.ctrlTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTo.Location = new System.Drawing.Point(66, 34);
            this.ctrlTo.Name = "ctrlTo";
            this.ctrlTo.Size = new System.Drawing.Size(1197, 20);
            this.ctrlTo.TabIndex = 4;
            // 
            // ctrlBCC
            // 
            this.ctrlBCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlBCC.Location = new System.Drawing.Point(66, 121);
            this.ctrlBCC.Name = "ctrlBCC";
            this.ctrlBCC.Size = new System.Drawing.Size(1197, 20);
            this.ctrlBCC.TabIndex = 5;
            // 
            // ctrlCC
            // 
            this.ctrlCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCC.Location = new System.Drawing.Point(66, 91);
            this.ctrlCC.Name = "ctrlCC";
            this.ctrlCC.Size = new System.Drawing.Size(1197, 20);
            this.ctrlCC.TabIndex = 6;
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlSubject.Location = new System.Drawing.Point(66, 63);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(1197, 20);
            this.ctrlSubject.TabIndex = 7;
            // 
            // loFrom
            // 
            this.loFrom.AutoSize = true;
            this.loFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loFrom.Location = new System.Drawing.Point(0, 10);
            this.loFrom.Name = "loFrom";
            this.loFrom.Size = new System.Drawing.Size(44, 15);
            this.loFrom.TabIndex = 8;
            this.loFrom.Text = "From:";
            // 
            // ctrlFrom
            // 
            this.ctrlFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFrom.Location = new System.Drawing.Point(66, 5);
            this.ctrlFrom.Name = "ctrlFrom";
            this.ctrlFrom.Size = new System.Drawing.Size(1197, 20);
            this.ctrlFrom.TabIndex = 9;
            // 
            // ctrlEmailBody
            // 
            this.ctrlEmailBody.Location = new System.Drawing.Point(1, 151);
            this.ctrlEmailBody.Name = "ctrlEmailBody";
            this.ctrlEmailBody.Size = new System.Drawing.Size(1262, 422);
            this.ctrlEmailBody.TabIndex = 10;
            this.ctrlEmailBody.Text = "";
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
            this.ctrlSend.Click += new System.EventHandler(this.ctrlSend_Click);
            // 
            // NewEmailF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 638);
            this.Controls.Add(this.ctrlSend);
            this.Controls.Add(this.ctrlEmailBody);
            this.Controls.Add(this.ctrlFrom);
            this.Controls.Add(this.loFrom);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCC);
            this.Controls.Add(this.ctrlBCC);
            this.Controls.Add(this.ctrlTo);
            this.Controls.Add(this.loBCC);
            this.Controls.Add(this.loSubject);
            this.Controls.Add(this.loCC);
            this.Controls.Add(this.loTo);
            this.Name = "NewEmailF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Email";
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
        private System.Windows.Forms.Label loFrom;
        private System.Windows.Forms.TextBox ctrlFrom;
        private System.Windows.Forms.RichTextBox ctrlEmailBody;
        private System.Windows.Forms.Button ctrlSend;
    }
}