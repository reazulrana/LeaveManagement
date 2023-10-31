using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SQLLibrary;
using System.Windows.Forms;

namespace DAL
{
  public  class SQLUser:IDataConnection
    {
        private string strcon = ConfigurationManager.ConnectionStrings["dbPayrollManagement"].ConnectionString;
        private string strcon1 = ConfigurationManager.ConnectionStrings["dbmaster"].ConnectionString;

        #region "Start Create Methods Section"
        public void CreateEmployee(Personal model)
        {
            throw new NotImplementedException("User Has No Create Permmission");
        }



        public void CreateLeaveDetails(LeaveDetails model)
        {
            throw new NotImplementedException("User Has No Create Permmission");
        }



        public void CreateContacts(Contacts model)
        {
            throw new NotImplementedException("User Has No Create Permmission");
        }


        public void CreateNidDetails(NIDDetails model)
        {


            throw new NotImplementedException("User Has No Create Permmission");
        }



        public void CreateUser(Users model)
        {

            throw new NotImplementedException("User Has No Create Permmission");

        }


        public void CreateMail(MailList model)
        {
            throw new NotImplementedException("User Has No Create Permmission");

        }

        #endregion "End Create Methods Section"


        #region "Start Update Methods Section"

        public void UpdateEmployee(Personal model)
        {
            throw new NotImplementedException("User Has No Update Permmission");
        }

        public void UpdateLeaveDetails(LeaveDetails model)
        {
            throw new NotImplementedException("User Has No Update Permmission");
        }

        public void UpdateContacts(Contacts model)
        {

            throw new NotImplementedException("User Has No Update Permmission");

        }

        public void UpdateNIDDetailsByNidID(NIDDetails model)
        {
            throw new NotImplementedException("User Has No Update Permmission");
        }


        public void UpdateUser(Users model)
        {
            DynamicParameters p = new DynamicParameters();


            throw new NotImplementedException("User Has No Update Permmission");
        }

        public void UpdateMail(MailList model)
        {
            throw new NotImplementedException("User Has No Update Permmission");
        }


        #endregion "End Update Methods Section"

        #region "Start Delete Methods Section"
        public void DeleteEmployee(string EmpCode)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }

        public void DeleteLeaveDetailsByID(int id)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }

        public void DeleteNIDDetails(int id)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }

        public void DeleteUser(int UID)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }

        public void DeleteMail(int mailid)
        {
            throw new NotImplementedException("User Has No Delete Permmission");
        }


        #endregion "End Delete Methods Section

        #region "Start Get Methods Section"
        //Get Employee Information, LeaveDetail, ContactList,NIDList,MailList
        public List<Personal> GetAllEmployee
        {
            get
            {

                List<Personal> output = new List<Personal>();
                using (IDbConnection con = new SqlConnection(strcon))
                {


                    output = con.Query<Personal>("spGetEMployee", null, commandType: CommandType.StoredProcedure).ToList();



                    foreach (Personal p in output)
                    {
                        p.leavedetails = GetLeaveDetailsbyCode(p.EmpCode);
                        p.ContactList = GetContactByEmpCode(p.EmpCode);
                        p.NIDList = GetNIDDetailsbyEmpCode(p.EmpCode);
                        p.MailList = GetMailByPerson(p.EmpCode);

                        p.TotalPL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "pl".ToLower()).Sum(x => x.TotalLeave);
                        p.TotalCL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "cl".ToLower()).Sum(x => x.TotalLeave);
                        p.TotalSL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "SL".ToLower()).Sum(x => x.TotalLeave);
                        p.TotalLWP = p.leavedetails.Where(x => x.LeaveType.ToLower() == "lwp".ToLower()).Sum(x => x.TotalLeave);
                        p.Advance = p.leavedetails.Where(x => x.LeaveType.ToLower() == "Advance".ToLower()).Sum(x => x.TotalLeave);
                        p.Maternity = p.leavedetails.Where(x => x.LeaveType.ToLower() == "Maternity".ToLower()).Sum(x => x.TotalLeave);

                        p.RemainingCL = LeaveDefault.Cl - p.TotalCL;
                        p.RemainingPL = LeaveDefault.Pl - p.TotalPL;
                        p.RemainingSL = LeaveDefault.Sl - p.TotalSL;
                    }

                }
                return output;
            }
        }
        //Get Employee Information, LeaveDetail (With Date Range), ContactList,NIDList,MailList
        public List<Personal> GetAllEmployees(DateTime StartDate, DateTime EndDate)
        {

            List<Personal> output = new List<Personal>();
            using (IDbConnection con = new SqlConnection(strcon))
            {


                output = con.Query<Personal>("spGetEMployee", null, commandType: CommandType.StoredProcedure).ToList();



                foreach (Personal p in output)
                {



                    p.leavedetails = GetLeaveDetailsbyDate(p.EmpCode, StartDate, EndDate);
                    p.ContactList = GetContactByEmpCode(p.EmpCode);
                    p.NIDList = GetNIDDetailsbyEmpCode(p.EmpCode);
                    p.MailList = GetMailByPerson(p.EmpCode);


                    p.TotalPL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "pl".ToLower()).Sum(x => x.TotalLeave);
                    p.TotalCL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "cl".ToLower()).Sum(x => x.TotalLeave);
                    p.TotalSL = p.leavedetails.Where(x => x.LeaveType.ToLower() == "SL".ToLower()).Sum(x => x.TotalLeave);
                    p.TotalLWP = p.leavedetails.Where(x => x.LeaveType.ToLower() == "lwp".ToLower()).Sum(x => x.TotalLeave);
                    p.Advance = p.leavedetails.Where(x => x.LeaveType.ToLower() == "Advance".ToLower()).Sum(x => x.TotalLeave);
                    p.Maternity = p.leavedetails.Where(x => x.LeaveType.ToLower() == "Maternity".ToLower()).Sum(x => x.TotalLeave);

                    p.RemainingCL = LeaveDefault.Cl - p.TotalCL;
                    p.RemainingPL = LeaveDefault.Pl - p.TotalPL;
                    p.RemainingSL = LeaveDefault.Sl - p.TotalSL;


                }

            }
            return output;
        }
        public Personal GetEmployeeByEmpCode(string empcode)
        {
            Personal output = new Personal();
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@EmpCode", empcode);

                output = con.QuerySingle<Personal>("spGetEmployeebyCode", p, commandType: CommandType.StoredProcedure);

            }

            return output;
        }

        //Get Leave detail by Employee Code for all year
        public List<LeaveDetails> GetLeaveDetailsbyCode(string Code)
        {
            List<LeaveDetails> output = new List<LeaveDetails>();
            using (IDbConnection con = new SqlConnection(strcon))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@EmpCode", Code);
                output = con.Query<LeaveDetails>("spGetLeaveDetailsbyCode", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        //Get Leave detail by Employee Code and Date Range
        public List<LeaveDetails> GetLeaveDetailsbyDate(string Code, DateTime StartDate, DateTime EndDate)
        {
            List<LeaveDetails> output = new List<LeaveDetails>();
            using (IDbConnection con = new SqlConnection(strcon))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@EmpCode", Code);
                p.Add("@FromDate", StartDate);
                p.Add("@ToDate", EndDate);
                output = con.Query<LeaveDetails>("spGetLeaveDetailsbyDate", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        //Get Leave detail by Date Range with Employee Name
        public List<LeaveDetailsExtraInfo> GetLeaveDetailsExtraInfo(DateTime fromdate, DateTime todate)
        {
            List<LeaveDetailsExtraInfo> output = new List<LeaveDetailsExtraInfo>();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                DynamicParameters p = new DynamicParameters();

                p.Add("@FromDate", fromdate);
                p.Add("@ToDate", todate);
                output = con.Query<LeaveDetailsExtraInfo>("spGetLeaveDetailsExtraInfo", p, commandType: CommandType.StoredProcedure).ToList();

            }




            return output;
        }

        //Get Contact detail with Filter by Employee Code
        public List<Contacts> GetContactByEmpCode(string EmpCode)
        {
            DynamicParameters p = new DynamicParameters();

            List<Contacts> output = new List<Contacts>();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@EmpCode", EmpCode);
                output = con.Query<Contacts>("spGetContactsByEmpCode", p, commandType: CommandType.StoredProcedure).ToList();

            }

            return output;
        }

        //Get All Contact detail with Employee Name
        public List<ContactExtraInfo> GetContactExtrainfo
        {
            get

            {


                List<ContactExtraInfo> output = new List<ContactExtraInfo>();

                using (IDbConnection con = new SqlConnection(strcon))
                {


                    output = con.Query<ContactExtraInfo>("spGetContactinfoExtra", null, commandType: CommandType.StoredProcedure).ToList();
                }
                return output;


            }
        }

        public List<NIDDetails> GetNIDDetailsbyEmpCode(string empcode)
        {
            DynamicParameters p = new DynamicParameters();
            List<NIDDetails> output = new List<NIDDetails>();

            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@empcode", empcode);

                output = con.Query<NIDDetails>("spGetNIDDetailsByEmpCode", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }



        public List<NidDetailsExtraInfo> GetNIDDetailsExtrainfo
        {
            get
            {

                List<NidDetailsExtraInfo> output = new List<NidDetailsExtraInfo>();
                using (IDbConnection con = new SqlConnection(strcon))
                {

                    output = con.Query<NidDetailsExtraInfo>("spGetNIDDetailsinfoExtra", null, commandType: CommandType.StoredProcedure).ToList();

                }
                return output;
            }
        }

        public List<Users> GetAllUser
        {
            get
            {

                List<Users> output = new List<Users>();

                using (IDbConnection con = new SqlConnection(strcon))
                {

                    try
                    {
                        output = con.Query<Users>("spGetAllUsers", null, commandType: CommandType.StoredProcedure).ToList();

                    }
                    catch
                    {
                        output = null;
                    }
                }
                return output;

            }
        }

        //Get Mail List Filter by Employee Code
        public List<MailList> GetMailByPerson(string empcode)
        {
            DynamicParameters p = new DynamicParameters();
            List<MailList> output = new List<MailList>();
            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@EmpCode", empcode);


                output = con.Query<MailList>("spGetMailByPersonID", p, commandType: CommandType.StoredProcedure).ToList();

            }

            return output;
        }


        public List<MailList> GetAllMail()
        {

            List<MailList> output = new List<MailList>();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                output = con.Query<MailList>("spGetAllMail", null, commandType: CommandType.StoredProcedure).ToList();

            }

            return output;
        }


        public string GetDatabaseName
        {
            get

            {

                string dbname = "";
                using (IDbConnection con = new SqlConnection(strcon))
                {

                    dbname = con.Database;

                }


                return dbname;
            }

        }

        #endregion "End Get Methods Section"

        #region "User Information Section"
        public Users UserVerify(Users model)
        {

            DynamicParameters p = new DynamicParameters();
            Users output = new Users();

            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@UserName", model.UserName);
                p.Add("@Password", model.Password);
                try
                {
                    output = con.QuerySingle<Users>("spUserVerify", p, commandType: CommandType.StoredProcedure);

                }
                catch
                {
                    output = null;
                }
            }
            return output;

        }









        #endregion

        #region "Database Back up Section"


        public void BackupDatabase(BackUp model)
        {
           DynamicParameters p = new DynamicParameters();
            SQLBACKUP bc = new SQLBACKUP(strcon1, model.SourceDatabase, model.FullPath, model.Name);
            bc.Backup();

        }



        public bool CheckDatabaseExistng
        {
            get
            {
                bool blnFlag = true;
                using (SqlConnection con = new SqlConnection(strcon))
                {

                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        blnFlag = false;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }


                return blnFlag;
            }
        }
        #endregion

        #region "Start Error Section"
        public void ErrorMessage(Exception e)
        {

            string strMsg = "";
            strMsg += "Message :" + Environment.NewLine;
            strMsg += e.Message + Environment.NewLine +  "________________________________________________" + Environment.NewLine;
            strMsg += "StackTrace :" + Environment.NewLine;
            strMsg += e.StackTrace + Environment.NewLine +"________________________________________________" + Environment.NewLine;
            strMsg += "InnerException  :" + Environment.NewLine;
            strMsg += e.InnerException + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "TargetSite  :" + Environment.NewLine;
            strMsg += e.TargetSite + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "Source  :" + Environment.NewLine;
            strMsg += e.Source + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "HResult :" + Environment.NewLine;
            strMsg += e.HResult + Environment.NewLine +"________________________________________________" + Environment.NewLine;
            strMsg += "Data    :" + Environment.NewLine;
            strMsg += "Data    :" + e.Data + Environment.NewLine + "________________________________________________" + Environment.NewLine;

            MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }





#endregion
    }
}
