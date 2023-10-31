using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSMSLibrary
{

    public enum MessageType
    {
        SMS,
        EMAIL
    }

    public enum MailType
    {
        gmail,
        hotmail,
        yahoo,
        aol,
        Custom


    }

    public class GlobalMailConfiguration
    {

        public static IEmailConfiguration _Iemail { get; set; }


        public static void SettingMail(MessageType messagetype,MailType mailtype,string smtp="",int port=0,bool ssl=false)
        {
            if (messagetype == MessageType.EMAIL)
            {
                if (mailtype == MailType.gmail)
                {
                    _Iemail = new Gmail();
                }
                else if (mailtype == MailType.Custom)
                {
                    _Iemail = new CustomeMail(smtp,port,ssl);
                }
            }
            else if(messagetype==MessageType.SMS)
            {
                
            }
        }

    }
}
