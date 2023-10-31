using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SQLLibrary
{
  public  class SQLBACKUP
    {


       private  string _SourceName = "";
        private  string _Location = "";
        private  string _Name = "";
        private  string  _connectionString = "Data Source=.;Initial Catalog=master";

        public SQLBACKUP(string connectionstring, string SourceName,string Location,string Name)
        {
            _SourceName = SourceName;
            _Location = Location;
            _Name = Name;
            _connectionString = connectionstring;
        }


        public  void Backup()
        {

            string strQueryBackup = " BACKUP DATABASE[" + _SourceName + "]";
            strQueryBackup += " TO DISK ='" + _Location + "'";
            strQueryBackup += " WITH NOFORMAT, NOINIT, NAME =N'" + _Name +"', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            using (SqlConnection con=new SqlConnection(_connectionString))
            {

                using (SqlCommand com = new SqlCommand(strQueryBackup, con))
                {
                    con.Open();

                    com.ExecuteNonQuery();
                                    }

            }
        }

    }
}
