using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSMSLibrary
{
   public class CustomeMail:IEmailConfiguration
    {


        private string _message;
        private string _subjects;
        private bool _ssl;
        private List<string> _attachments;
        private string _smtp;

        private int _port;


        public CustomeMail(string smtp,int port,bool ssl)
        {
            _smtp = smtp;
            _port = port;
            _ssl = ssl;
        }
        
        public string SMTP
        {

            get
            {
            
    return _smtp;
            }
        }


        public int Port
        {
            get
            {
                return _port;
            }
        }


        public List<string> Attachments
        {
            get
            {
                return _attachments;
            }

            set
            {
                _attachments = value;
            }
        }



        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        public bool SSL
        {
            get
            {
                return _ssl;
            }


        }


        public string Subjects
        {
            get
            {
                return _subjects;
            }

            set
            {
                _subjects = value;
            }
        }



        public void Send(string from, List<string> to, string password, bool isBodyHtml = false)
        {
            MailMessage mailmessage = new MailMessage();
            MailAddress mailfrom = new MailAddress(from);

            mailmessage.From = mailfrom;
            mailmessage.Subject = Subjects;
            mailmessage.Body = Message;

            foreach (string toemail in to)
            {
                mailmessage.To.Add(toemail);
            }

            SmtpClient smtpclient = new SmtpClient(SMTP, Port);
            smtpclient.Credentials = new NetworkCredential(from, password);


            if (mailmessage.Attachments.Count > 0)
            {
                mailmessage.Attachments.Dispose();
            }

            if (Attachments != null)
            {
                foreach (string attachment in Attachments)
                {
                    Attachment a = new Attachment(attachment);

                    mailmessage.Attachments.Add(a);
                }

            }

            smtpclient.EnableSsl = SSL;

            smtpclient.Send(mailmessage);

        }
    }
}
