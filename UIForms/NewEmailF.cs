using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailEngine;
using System.Threading;
using MimeKit;


namespace UIForms {
    public partial class NewEmailF : Form {

        public SendClient sendClient;

        public NewEmailF() {
            InitializeComponent();
        }

        public void Init() {
            sendClient.OnEmailSend += sendClient_OnEmailSend;
        }

        private void sendClient_OnEmailSend(object state) {
            MimeMessage message = state as MimeMessage;
        }

        private void ctrlSend_Click(object sender, EventArgs e) {

            string from = ctrlFrom.Text;
            string to = ctrlTo.Text;
            string subject = ctrlSubject.Text;
            string emailBody = ctrlEmailBody.Text;
            sendClient.SendMessage(from, to, subject, emailBody);
        }
    }
}
