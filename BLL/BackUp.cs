using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BackUp
    {
        public string SourceDatabase { get; set; }
        public string BackupName { get; set; }

        public string Location { get; set; }
        public string Name { get {


                return SourceDatabase + "-Full Backup";
            } }
        public string FullPath
        {
            get
            {

                string strpath = "";
          
                    strpath = Location + "\\" + BackupName + ".bak";
              
               return strpath;
            }
        }
    }
}
