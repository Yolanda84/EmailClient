using EmailEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForms {
    public partial class AccountSettingsF : Form {

        public string POP3ServerAdr = "";
        public int POP3ServerPort = 0;
        public string POP3Username = "";
        public string POP3Password = "";
        public bool POP3UseSSL = false;

        public string SMTPServerAdr = "";
        public int SMTPServerPort = 0;
        public string SMTPUsername = "";
        public string SMTPPassword = "";
        public bool SMTPUseSSL = false;

        public AccountSettingsF() {
            InitializeComponent();
        }

        public void SetValues() {
            ctrlPOP3ServerAddress.Text = POP3ServerAdr;
            ctrlPOP3ServerPort.Text = Convert.ToString(POP3ServerPort);
            ctrlPOP3UseSSL.Checked = POP3UseSSL;
            ctrlPOP3Username.Text = POP3Username;
            ctrlPOP3Password.Text = POP3Password;

            ctrlSMTPServerAddress.Text = SMTPServerAdr;
            ctrlSMTPServerPort.Text = Convert.ToString(SMTPServerPort);
            ctrlSMTPUseSSL.Checked = SMTPUseSSL;
            ctrlSMTPUsername.Text = SMTPUsername;
            ctrlSMTPPassword.Text = SMTPPassword;
        }

        private void ctrlSave_Click(object sender, EventArgs e) {
            POP3ServerAdr = ctrlPOP3ServerAddress.Text;
            POP3ServerPort = Convert.ToInt32(ctrlPOP3ServerPort.Text);
            POP3Username = ctrlPOP3Username.Text;
            POP3Password = ctrlPOP3Password.Text;
            POP3UseSSL = ctrlPOP3UseSSL.Checked;

            SMTPServerAdr = ctrlSMTPServerAddress.Text;
            SMTPServerPort = Convert.ToInt32(ctrlSMTPServerPort.Text);
            SMTPUsername = ctrlSMTPUsername.Text;
            SMTPPassword = ctrlSMTPPassword.Text;
            SMTPUseSSL = ctrlSMTPUseSSL.Checked;

            this.Close();

        }

        
    }
}
