using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace EmailEngine {
    public class PopClient {

        List<string> uIdsLoaded = null;

        public PopClient() {
            bool fileexists = File.Exists("uids.txt");
            if (fileexists == true) {
                string[] tempUids = File.ReadAllLines("uids.txt");
                uIdsLoaded = new List<string>(tempUids);
            }
            else {
                uIdsLoaded = new List<string>();
            }
        }

        public string Pop3ServerAdr = "";
        public int Pop3ServerPort = 0;
        public string Pop3Username = "";
        public string Pop3Password = "";
        public bool Pop3UseSSL = false;

        public event SendOrPostCallback OnEmailReceive;
        public event SendOrPostCallback OnUIDsReceived;

        public void ReceiveMails(SynchronizationContext syncContext) {
            Pop3Client client = new Pop3Client();
            // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect(Pop3ServerAdr, Pop3ServerPort, Pop3UseSSL);

            client.Authenticate(Pop3Username, Pop3Password);

            if (!client.Capabilities.HasFlag(Pop3Capabilities.UIDL))
                throw new Exception("The POP3 server does not support UIDs!");

            var uids = client.GetMessageUids();
            if (OnUIDsReceived != null) {
                syncContext.Send(OnUIDsReceived, uids.Count);
            }

            int localUidsNo = uids.Count;

            for (int i = client.Count - 1; i >= 0; i--) {
                string uid = uids[i];
                // check that we haven't already downloaded this message
                // in a previous session
                if (uIdsLoaded.Contains(uid)) {
                    if (OnUIDsReceived != null) {
                        syncContext.Send(OnUIDsReceived, localUidsNo = localUidsNo - 1);
                    }
                    continue;
                }

                //for (int i = client.Count - 1; i >= client.Count - 6; i--) {
                //for (int i = 0; i < 5; i++) {
                var message = client.GetMessage(i);

                // write the message to a file

                //if (uids.Contains("\\")) {
                //    string nonInvalidUID = Convert.ToString(uids);
                //    nonInvalidUID = nonInvalidUID.Replace("\\", "**");
                //    message.WriteTo(string.Format("{0}.msg", nonInvalidUID));
                //}
                //else {
                //    message.WriteTo(string.Format("{0}.msg", uids[i]));
                //}

                if (OnEmailReceive != null) {
                    syncContext.Send(OnEmailReceive, message);
                }

                // add the message uid to our list of downloaded uids
                //Directory.CreateDirectory("Uids");

                uIdsLoaded.Add(uid);
                File.AppendAllText("uids.txt", "\n" + uid);
            }
            client.Disconnect(true);
        }
    }
}
    

