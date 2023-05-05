using System.Net;
using System.Net.Mail;

namespace Zadanie06
{
    public partial class Form1 : Form
    {

        private OpenFileDialog ofd;
        private SmtpClient smtpClient = new SmtpClient();
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            initializeSMTP();


        }

        private void initializeSMTP()
        {
            smtpClient.Host = "sandbox.smtp.mailtrap.io";
            smtpClient.Port = 2525;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("b3fdbd14304b7d", "e2f7103234f93e");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachmentPwd.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            attachmentPwd.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //smtpClient.Send("example@example.com", toText.Text, topic.Text, message.Text);

            var message = new MailMessage("example@example.com", toText.Text)
            {
                Subject = topic.Text,
                Body = this.message.Text
            };

            if (attachmentPwd.Text != null && !attachmentPwd.Text.Equals(""))
            {
                var attachment = new Attachment(attachmentPwd.Text);
                message.Attachments.Add(attachment);
            }

            smtpClient.Send(message);
        }
    }
}