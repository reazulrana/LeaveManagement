using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BLL
{
  public static  class LeaveDefault
    {

        private static int _cl=Convert.ToInt32(ConfigurationManager.AppSettings["CL"]);
        private static int _pl = Convert.ToInt32(ConfigurationManager.AppSettings["PL"]);
        private static int _sl = Convert.ToInt32(ConfigurationManager.AppSettings["SL"]);

  

        public static int Cl
        {
            get
            {
                return _cl;
            }


        }

        public static int Pl
        {
            get
            {
                return _pl;
            }

          
        }

        public static int Sl
        {
            get
            {
                return _sl;
            }

           
        }
    }
}
