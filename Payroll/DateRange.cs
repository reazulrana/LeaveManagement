using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Payroll
{
   public  class DateRange
    {


        static string SDate = ConfigurationManager.AppSettings["startdate"];//StartDate Date
     

        public static DateTime StartDate { get
            {

                string date = "";
                if (SDate.ToLower() == "Jul".ToLower())
                {
                    date = "01-Jul-" + DateTime.Now.Year;
                }
                else
                {
                    date = "01-Jan-" + DateTime.Now.Year;
                }


                return Convert.ToDateTime(date);
            } }


        public static DateTime EndtDate
        {
            get
            {
                string date = "";
                if (SDate.ToLower() == "Jul".ToLower())
                {
                    date = "30-Jun-" + (DateTime.Now.Year+1);
                }
                else
                {
                    date = "31-Dec-" + DateTime.Now.Year;
                }


                return Convert.ToDateTime(date);
            }
        }
    }
}
