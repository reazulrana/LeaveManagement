using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Configuration;
namespace DAL
{

    public enum ConnectionType
    {
        SQL,
        Oracle,
        MySQL
    }

    public enum TypeofUser
    {
        admin,
        user
    }

  public static  class GlobalConfig
    {

        public static IDataConnection iDataConnection { get; set; }
        static DateTime dateexpire = Convert.ToDateTime(ConfigurationManager.AppSettings["exdate"]);

        public static void Inithialize(ConnectionType connectiontype)
        {


            

            if (DateTime.Now.Subtract(dateexpire).Days >= 1) //if Date Is expire Then Fired 
            {

                iDataConnection = new SQLUser();
                return;
                throw new NotImplementedException("You Application is not Healthy Mode");
                
            }

            if (connectiontype == ConnectionType.SQL)
            {
                iDataConnection = new SQLUser();
            }
        }


        public static void Config(ConnectionType connectiontype, TypeofUser typeofuser)
        {

            if (DateTime.Now.Subtract(dateexpire).Days >= 1) //if Date Is expire Then Fired 
            {
                iDataConnection = new SQLUser();
                return;
                //throw new NotImplementedException("You Application is not Healthy Mode");

            }



            if (connectiontype == ConnectionType.SQL)
            {
                if (typeofuser.ToString().ToLower() == TypeofUser.admin.ToString().ToLower()) { 

            iDataConnection = new SQLAdmin();
                }
                else if(typeofuser.ToString().ToLower() == TypeofUser.user.ToString().ToLower())
                {
                    iDataConnection = new SQLUser();
                }
            }
        }

    }
}
