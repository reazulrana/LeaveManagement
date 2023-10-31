using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RestoreDatabase
    {

        public string RestorePath { get; set; }
        public string TargetPath { get; set; }
        public string DatabaseName { get; set; }
        public string MoveDatabasePrimery { get; set; }
        public string MoveDatabaseLog { get; set; }
        public string MDFTarget
        {
            get
            {


                string path = TargetPath + "\\" + DatabaseName + ".mdf";

                return path;

            }
        }
        public string LDFTarget
        {
            get
            {


                string path = TargetPath + "\\" + DatabaseName + ".ldf";

                return path;

            }



        }
    }
}
