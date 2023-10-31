using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Security;
namespace EmailSMSLibrary
{
 public   interface IEmailConfiguration
    {

        string Message { get; set; }
       
       string SMTP { get; }
        int Port { get; }
        string Subjects { get; set; }
        bool SSL { get; }
        List<string> Attachments { get; set; }
       
        void Send(string from,List<string> to,string password,bool isBodyHtml=false);

    }
}
