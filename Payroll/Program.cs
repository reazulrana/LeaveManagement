using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using EmailSMSLibrary;
using System.Configuration;

namespace Payroll
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static frmMain formMain;
  
        [STAThread]
                
        static void Main()
        {
            try { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.Inithialize(ConnectionType.SQL);// This is declared for Login
            //GlobalMailConfiguration.SettingMail(MessageType.EMAIL, MailType.Custom,ConfigurationManager.AppSettings["customSMTP"], Convert.ToInt32(ConfigurationManager.AppSettings["customSMTPPORT"]), Convert.ToBoolean(ConfigurationManager.AppSettings["customSSL"]));
            GlobalMailConfiguration.SettingMail(MessageType.EMAIL, MailType.gmail);

            formMain = new frmMain();
              
            Application.Run(formMain);
            }
            catch(Exception ex)
            {

                //DAte Expiration Messge Notification
                MessageBox.Show(ex.Message, "Contact to the administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void ConfigFunction(TypeofUser usertype)
        {


            GlobalConfig.Config(ConnectionType.SQL,usertype);
        }

    }
}
