using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SQLLibrary
{
 public   class SQLRestore
    {

        private string _RestorePath;
        private string _TargetPath;
        private string _DatabaseName;
        private string _OriginalDatabase;
        private string _MoveDatabasePrimery;
        private string _MoveDatabaseLog;
       string _connectionString = "Data Source=.;Initial Catalog=master;Integrated Security=True";


        public SQLRestore()
        {
          
        }
        public SQLRestore(string strconnectionString)
        {
            _connectionString = strconnectionString;
        }
        public string RestorePath
        {
            get
            {
                return _RestorePath;
            }

            set
            {
                _RestorePath = value;
            }
        }

        public string TargetPath
        {
            get
            {
                return _TargetPath;
            }

            set
            {
                _TargetPath = value;
            }
        }


        public string OriginalDatabase
        {
            get
            {
                return _OriginalDatabase;
            }

            set
            {
                _OriginalDatabase = value;
            }
        }

        public string DatabaseName
        {
            get
            {
                return _DatabaseName;
            }

            set
            {
                _DatabaseName = value;
            }
        }

        public string MoveDatabasePrimery
        {
            get
            {
                return _MoveDatabasePrimery;
            }

            set
            {
                _MoveDatabasePrimery = value;
            }
        }

        public string MoveDatabaseLog
        {
            get
            {
                return _MoveDatabaseLog;
            }

            set
            {
                _MoveDatabaseLog = value;
            }
        }


        private string MDFTarget
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


        public void Restore()
        {


            string strQueryRestore = "RESTORE DATABASE[" + DatabaseName + "] ";
            strQueryRestore += "FROM DISK = N'" + RestorePath + "' WITH FILE = 1,";
            strQueryRestore += "MOVE N'" + MoveDatabasePrimery + "'";
            strQueryRestore += "TO N'" + MDFTarget  +"',";
            strQueryRestore += "MOVE N'" +MoveDatabaseLog+ "'";
            strQueryRestore += "TO N'" + LDFTarget + "',";
            strQueryRestore += "NOUNLOAD,  STATS = 10";



            using (SqlConnection con = new SqlConnection(ConnString))
            {

                using (SqlCommand com = new SqlCommand(strQueryRestore, con))
                {
                    con.Open();

                    com.ExecuteNonQuery();
                }

            }
        }


        private string ConnString
        {
            get { 

                            return _connectionString;
            }
        }
    }
}
