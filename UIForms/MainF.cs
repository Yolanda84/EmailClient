using EmailEngine;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace UIForms {
    public partial class MainF : Form {

        PopClient pop = new PopClient();
        SendClient send = new SendClient();
        EmailAccountSettings emailAccountSettings = new EmailAccountSettings();
        List<EmailInfo> EmailinfoData = new List<EmailInfo>();
        List<MimeMessage> mimeMessages = new List<MimeMessage>();
        
        public MainF() {
            InitializeComponent();

            emailAccountSettings.ReadSettingsFromFile();

            EmailinfoData = ReadEmailInfo();

            pop.Pop3ServerAdr = emailAccountSettings.POP3ServerAdr;
            pop.Pop3ServerPort = emailAccountSettings.POP3ServerPort;
            pop.Pop3Username = emailAccountSettings.POP3Username;
            pop.Pop3Password = emailAccountSettings.POP3Password;
            pop.Pop3UseSSL = emailAccountSettings.POP3UseSSL;

            send.SMTPServerAdr = emailAccountSettings.SMTPServerAdr;
            send.SMTPServerPort = emailAccountSettings.SMTPServerPort;
            send.SMTPUsername = emailAccountSettings.SMTPUsername;
            send.SMTPPassword = emailAccountSettings.SMTPPassword;
            send.SMTPUseSSL = emailAccountSettings.SMTPUseSSL;

            pop.OnEmailReceive += Pop_OnEmailReceive;
            pop.OnUIDsReceived += Pop_OnUIDsReceived;

            Directory.CreateDirectory("Emails");

            string[] emails = Directory.GetFiles("Emails", "*.msg");
            loEmailCounter.Text = Convert.ToString(emails.Length);
            //int readEmails = EmailinfoData.Sum(x => Convert.ToInt32(x.ReadStatus));
            loReadEmailsCounter.Text = ReadEmailsCounter(EmailinfoData);

            foreach (string emailFile in emails) {
                FileStream stream = File.OpenRead(emailFile);
                string tempemailID = emailFile.Remove(emailFile.Length - 4);
                string emailID = tempemailID.Substring(7);
                MimeParser parser = new MimeParser(stream);
                MimeMessage msg = parser.ParseMessage();

                var x = new DataGridViewRow();
                x.CreateCells(dataGridView1);
                x.SetValues(emailID, msg.From, msg.Subject, Convert.ToString(msg.Date));
                dataGridView1.Rows.Add(x);

                mimeMessages.Add(msg);
            }
        }

        private void Pop_OnUIDsReceived(object state) {
            int uidsCount = (int)state;
            ctrlProgressBar.Maximum = uidsCount;
            loEmailNumber.Text = ctrlProgressBar.Value + "//" + Convert.ToString(uidsCount);
        }

        private void Pop_OnEmailReceive(object state) {

            string emailID = Convert.ToString(Guid.NewGuid());
            MimeMessage msg = state as MimeMessage;
            var x = new DataGridViewRow();
            x.CreateCells(dataGridView1);
            x.SetValues(emailID, msg.From, msg.Subject, Convert.ToString(msg.Date));
            dataGridView1.Rows.Add(x);

            mimeMessages.Add(msg);

            ctrlProgressBar.Value += 1;
            loEmailNumber.Text = ctrlProgressBar.Value + "//" + Convert.ToString(ctrlProgressBar.Maximum);

            EmailInfo emailInfo = new EmailInfo();
            emailInfo.ReadStatus = false;
            emailInfo.EmailID = emailID;
            emailInfo.MessageID = msg.MessageId;
            EmailinfoData.Add(emailInfo);

            WriteEmailInfo(EmailinfoData);

            msg.WriteTo("Emails\\" + emailID + ".msg");
        }

        private void ctrlNewEmail_Click(object sender, EventArgs e) {
        }

        private void ctrlReceiveEmails_Click(object sender, EventArgs e) {
            var syncContext = SynchronizationContext.Current;
            Task.Run(() => pop.ReceiveMails(syncContext));
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void menuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public void menuSettings_Click(object sender, EventArgs e) {
            AccountSettingsF settings = new AccountSettingsF();

            settings.POP3ServerAdr = emailAccountSettings.POP3ServerAdr;
            settings.POP3ServerPort = emailAccountSettings.POP3ServerPort;
            settings.POP3Username = emailAccountSettings.POP3Username;
            settings.POP3Password = emailAccountSettings.POP3Password;
            settings.POP3UseSSL = emailAccountSettings.POP3UseSSL;

            settings.SMTPServerAdr = emailAccountSettings.SMTPServerAdr;
            settings.SMTPServerPort = emailAccountSettings.SMTPServerPort;
            settings.SMTPUsername = emailAccountSettings.SMTPUsername;
            settings.SMTPPassword = emailAccountSettings.SMTPPassword;
            settings.SMTPUseSSL = emailAccountSettings.SMTPUseSSL;

            settings.SetValues();

            settings.ShowDialog();

            emailAccountSettings.POP3ServerAdr = settings.POP3ServerAdr;
            emailAccountSettings.POP3ServerPort = settings.POP3ServerPort;
            emailAccountSettings.POP3Username = settings.POP3Username;
            emailAccountSettings.POP3Password = settings.POP3Password;
            emailAccountSettings.POP3UseSSL = settings.POP3UseSSL;

            emailAccountSettings.SMTPServerAdr = settings.SMTPServerAdr;
            emailAccountSettings.SMTPServerPort = settings.SMTPServerPort;
            emailAccountSettings.SMTPUsername = settings.SMTPUsername;
            emailAccountSettings.SMTPPassword = settings.SMTPPassword;
            emailAccountSettings.SMTPUseSSL = settings.SMTPUseSSL;

            emailAccountSettings.WriteSettingsToFile();
        }

        public void menuGeneral_Click(object sender, EventArgs e) {
            GeneralSettingsF general = new GeneralSettingsF();
            general.ShowDialog();
        }

        private void menuNewEmail_Click(object sender, EventArgs e) {
            NewEmailF newEmail = new NewEmailF();
            newEmail.sendClient = send;
            newEmail.Init();
            newEmail.ShowDialog();
        }

        public List<EmailInfo> ReadEmailInfo() {
            
            var serial = new JavaScriptSerializer();

            if (File.Exists("EmailInfo.json")) {
                string json = File.ReadAllText("EmailInfo.json");
                List<EmailInfo> infos = serial.Deserialize<List<EmailInfo>>(json) as List<EmailInfo>;
                return infos;
            }
            else {
                return new List<EmailInfo>();
            }
        }

        public void WriteEmailInfo(List<EmailInfo> data) {
            var serial = new JavaScriptSerializer();
            string json = serial.Serialize(data);

            File.WriteAllText("EmailInfo.json", json);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {                        
            if (e.RowIndex < 0) {
                return;
            }

            string focusedEmailID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            EmailInfo mailInfo = EmailinfoData.Find(x => x.EmailID == focusedEmailID);
            mailInfo.ReadStatus = true;
            ReadEmailsCounter(EmailinfoData);

            MimeMessage message = mimeMessages.Find(x => x.MessageId == mailInfo.MessageID);
            ctrlEmailBody.Text = message.TextBody;
            webBrowser1.DocumentText = message.HtmlBody;

            WriteEmailInfo(EmailinfoData);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) {
                return;
            }

            string focusedEmailID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            EmailInfo mailInfo = EmailinfoData.Find(x => x.EmailID == focusedEmailID);
            mailInfo.ReadStatus = true;
            ReadEmailsCounter(EmailinfoData);

            MimeMessage message = mimeMessages.Find(x => x.MessageId == mailInfo.MessageID);
            EmailWindowF emailWindow = new EmailWindowF();
            emailWindow.mimeMessage = message;
            emailWindow.SetWindowMessageValues();
            emailWindow.ShowDialog();
        }

        public string ReadEmailsCounter(List<EmailInfo> data) { 
        int readEmails = EmailinfoData.Sum(x => Convert.ToInt32(x.ReadStatus));
        return loReadEmailsCounter.Text = Convert.ToString(readEmails);}
    }
}
