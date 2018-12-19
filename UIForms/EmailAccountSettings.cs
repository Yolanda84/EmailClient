using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UIForms {
    public class EmailAccountSettings {
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

        public void ReadSettingsFromFile() {
            Type tp = typeof(EmailAccountSettings);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(tp);

            FileStream fs = new FileStream("settings.json", FileMode.OpenOrCreate);
            EmailAccountSettings res = ser.ReadObject(fs) as EmailAccountSettings;
            POP3ServerAdr = res.POP3ServerAdr;
            POP3ServerPort = res.POP3ServerPort;
            POP3Username = res.POP3Username;
            POP3Password = res.POP3Password;
            POP3UseSSL = res.POP3UseSSL;

            SMTPServerAdr = res.SMTPServerAdr;
            SMTPServerPort = res.SMTPServerPort;
            SMTPUsername = res.SMTPUsername;
            SMTPPassword = res.SMTPPassword;
            SMTPUseSSL = res.SMTPUseSSL;
        }

        public void WriteSettingsToFile() {
            Type tp = typeof(EmailAccountSettings);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(tp);

            FileStream fs = new FileStream("settings.json", FileMode.Create);
            ser.WriteObject(fs, this);
            fs.Close();
        }
    }
}
