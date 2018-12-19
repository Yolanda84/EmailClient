using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailEngine {
    public class SendClient {

        public string ServerAdr1 { get; private set; }
        public string SMTPServerAdr = "";
        public int SMTPServerPort = 0;
        public string SMTPUsername = "";
        public string SMTPPassword = "";
        public bool SMTPUseSSL = false;

        public event SendOrPostCallback OnEmailSend;

            public void SendMessage(string from, string to, string subject, string emailBody) {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(from));
                message.To.Add(new MailboxAddress(to));
                message.Subject = subject;

                BodyBuilder builder = new BodyBuilder();

                builder.TextBody = emailBody;

                //builder.Attachments.Add(@"C:\file\data.xlxs");

                message.Body = builder.ToMessageBody();

                SmtpClient sendClient = new SmtpClient();

                sendClient.Connect(SMTPServerAdr, SMTPServerPort, SMTPUseSSL);
                sendClient.Authenticate(SMTPUsername, SMTPPassword);

                sendClient.Send(message);

                if (OnEmailSend != null) {
                OnEmailSend(message);
                }

                sendClient.Disconnect(true);
            }
        
        }
    }
