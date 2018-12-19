using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UIForms {
    public partial class EmailWindowF : Form {

        public MimeMessage mimeMessage;

        public EmailWindowF() {
            InitializeComponent();
        }

        public void SetWindowMessageValues() {

            ctrlFrom.Text = Convert.ToString(mimeMessage.From);
            ctrlSubject.Text = mimeMessage.Subject;
            ctrlTo.Text = Convert.ToString(mimeMessage.To);
            ctrlBCC.Text = Convert.ToString(mimeMessage.Bcc);
            ctrlCC.Text = Convert.ToString(mimeMessage.Cc);
            webBrowser1.DocumentText = mimeMessage.HtmlBody;
            this.Text = mimeMessage.Subject;
            ctrlDate.Value = mimeMessage.Date.LocalDateTime;


            if (mimeMessage.Attachments.Count() > 0) {
                foreach (MimeEntity att in mimeMessage.Attachments) {
                    if (att is TextPart) {
                        TextPart attTxtPrt = att as TextPart;
                        ctrlAttachementListbox.Items.Add(attTxtPrt.FileName);
                    }
                }
            }
        }

        private void ctrlAttachementListbox_MouseDoubleClick(object sender, MouseEventArgs e) {
            object selectedItem = ctrlAttachementListbox.SelectedItem;
            if (selectedItem == null) {
                return;
            }

            foreach (MimeEntity att in mimeMessage.Attachments) {
                if (att is TextPart) {
                    TextPart attTxtPrt = att as TextPart;
                    if (attTxtPrt.FileName == Convert.ToString(selectedItem)) {
                        Directory.CreateDirectory("Attachments");

                        string attachmentFileName = "Attachments\\" + attTxtPrt.FileName;
                        using (var stream = File.Create(attachmentFileName)) {
                            if (att is MessagePart) {
                                var part = (MessagePart)att;

                                part.Message.WriteTo(stream);
                            }
                            else {
                                var part = (MimePart)att;

                                part.Content.DecodeTo(stream);
                            }
                        }
                        System.Diagnostics.Process.Start(attachmentFileName);
                    }
                }
            }
        }
    }
}
