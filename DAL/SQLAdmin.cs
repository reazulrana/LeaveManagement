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
    public class SQLAdmin : IDataConnection
    {
        private string strcon = ConfigurationManager.ConnectionStrings["dbPayrollManagement"].ConnectionString;
        private string strcon1 = ConfigurationManager.ConnectionStrings["dbmaster"].ConnectionString;

        #region "Start Create Methods Section"
        public void CreateEmployee(Personal model)
        {
            using (IDbConnection con = new SqlConnection(strcon))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@EmpName", model.EmpName);
                p.Add("@Designation", model.Designation);
                p.Add("@Branch", model.Branch);
                p.Add("@Qualification", model.Qualification);
                p.Add("@DateOfBirth", model.DateOfBirth);
                p.Add("@AppointDate", model.DateOfBirth); // Date of Appointment
                p.Add("@IDAssignDate", model.IDAssignDate);
                p.Add("@BloodGruop", model.IDAssignDate);
                p.Add("@JoiningDate", model.IDAssignDate);
                p.Add("@Photo", model.Photo);

                con.Execute("spCreateEmplyee", p, commandType: CommandType.StoredProcedure);

            }
        }



        public void CreateLeaveDetails(LeaveDetails model)
        {
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@EntryDate", model.EntryDate);
                p.Add("@LeaveType", model.LeaveType);
                p.Add("@FromDate", model.FromDate);
                p.Add("@ToDate", model.ToDate);
                p.Add("@TotalLeave", model.TotalLeave);
                p.Add("@ReasonofLeave", model.ReasonofLeave);
                p.Add("@FileName", model.FileName);
                if (model.Attachements != null)
                {
                    p.Add("@Attachements", model.Attachements);
            }
            con.Execute("spCreateLeaveDetails", p, commandType: CommandType.StoredProcedure);

            }
        }



        public void CreateContacts(Contacts model)
        {
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@ContactNo", model.ContactNo);
                p.Add("@Operator", model.Operator);
                p.Add("@IssueDate", model.IssueDate);
                p.Add("@Remarks", model.Remarks);


                con.Execute("spCreateContact", p, commandType: CommandType.StoredProcedure);

            }
        }


        public void CreateNidDetails(NIDDetails model)
        {


            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@CardAssignDate", model.CardAssignDate);
                p.Add("@NIDNumber", model.NIDNumber);
                p.Add("@Remarks", model.Remarks);


                con.Execute("spCreateNIDDetails", p, commandType: CommandType.StoredProcedure);
            }
        }



        public void CreateUser(Users model)
        {

            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@UserName", model.UserName);
                p.Add("@Password", model.Password);
                p.Add("@Type", model.Type);

                con.Execute("spCreateUser", p, commandType: CommandType.StoredProcedure);


            }

        }


        public void CreateMail(MailList model)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@EmpCode", model.EmpCode);
                p.Add("@EmailNo", model.EmailNo);

                con.Execute("spCreateMailByPerson", p, commandType: CommandType.StoredProcedure);

            }

        }

        #endregion "End Create Methods Section"

        
        #region "Start Update Methods Section"

        public void UpdateEmployee(Personal model)
        {
            using (IDbConnection con = new SqlConnection(strcon))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@EmpName", model.EmpName);
                p.Add("@Designation", model.Designation);
                p.Add("@Branch", model.Branch);
                p.Add("@Qualification", model.Qualification);
                p.Add("@DateOfBirth", model.DateOfBirth);
                p.Add("@AppointDate", model.AppointDate); // Date of Appointment
                p.Add("@IDAssignDate", model.IDAssignDate);
                p.Add("@BloodGruop", model.BloodGruop);
                p.Add("@JoiningDate", model.JoiningDate);
                p.Add("@Photo", model.Photo);

                con.Execute("spUpdateEmplyee", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void UpdateLeaveDetails(LeaveDetails model)
        {
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@LDID", model.LDID);
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@EntryDate", model.EntryDate);
                p.Add("@LeaveType", model.LeaveType);
                p.Add("@FromDate", model.FromDate);
                p.Add("@ToDate", model.ToDate);
                p.Add("@TotalLeave", model.TotalLeave);
                p.Add("@ReasonofLeave", model.ReasonofLeave);
                p.Add("@FileName", model.FileName);
                if (model.Attachements != null)
                {
                    p.Add("@Attachements", model.Attachements);
                }
                con.Execute("spUpdateLeaveDetails", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void UpdateContacts(Contacts model)
        {

            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@ContactID", model.ContactID);
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@ContactNo", model.ContactNo);
                p.Add("@Operator", model.Operator);
                p.Add("@IssueDate", model.IssueDate);
                p.Add("@Remarks", model.Remarks);

                con.Execute("spUpdateContact", p, commandType: CommandType.StoredProcedure);

            }

        }

        public void UpdateNIDDetailsByNidID(NIDDetails model)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@NIDID", model.NIDID);
                p.Add("@EmpCode", model.EmpCode.ToUpper());
                p.Add("@CardAssignDate", model.CardAssignDate);
                p.Add("@NIDNumber", model.NIDNumber);
                p.Add("@Remarks", model.Remarks);


                con.Execute("spUpdateNIDDetailsByNidID", p, commandType: CommandType.StoredProcedure);
            }
        }


        public void UpdateUser(Users model)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@UID", model.UID);
                p.Add("@UserName", model.UserName);
                p.Add("@Password", model.Password);
                p.Add("@Type", model.Type);

                con.Execute("spUpdateUser", p, commandType: CommandType.StoredProcedure);


            }
        }

        public void UpdateMail(MailList model)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@MailID", model.MailID);
                p.Add("@EmpCode", model.EmpCode);
                p.Add("@EmailNo", model.EmailNo);

                con.Execute("spUpdateMailByMailid", p, commandType: CommandType.StoredProcedure);

            }
        }


        #endregion "End Update Methods Section"
        
        #region "Start Delete Methods Section"
        public void DeleteEmployee(string EmpCode)
        {
            using (IDbConnection con = new SqlConnection(strcon))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@EmpCode", EmpCode);


                con.Execute("spDeletePersonalByEmpCode", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void DeleteLeaveDetailsByID(int id)
        {
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {

                p.Add("@LDID", id);


                con.Execute("spDeleteLeaveDetailsByID", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void DeleteContact(int id)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@ContactID", id);
                con.Execute("spDeleteContact", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteNIDDetails(int id)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@NIDID", id);

                con.Execute("spDeleteNIDDetailsByNidID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteUser(int UID)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@UID", UID);


                con.Execute("spDeleteUser", p, commandType: CommandType.StoredProcedure);


            }
        }

        public void DeleteMail(int mailid)
        {
            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = new SqlConnection(strcon))
            {
                p.Add("@MailID", mailid);


                con.Execute("spDeleteMail", p, commandType: CommandType.StoredProcedure);

            }
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
            //DynamicParameters p = new DynamicParameters();
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
            strMsg += e.Message + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "StackTrace :" + Environment.NewLine;
            strMsg += e.StackTrace + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "InnerException  :" + Environment.NewLine;
            strMsg += e.InnerException + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "TargetSite  :" + Environment.NewLine;
            strMsg += e.TargetSite + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "Source  :" + Environment.NewLine;
            strMsg += e.Source + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "HResult :" + Environment.NewLine;
            strMsg += e.HResult + Environment.NewLine + "________________________________________________" + Environment.NewLine;
            strMsg += "Data    :" + Environment.NewLine;
            strMsg += "Data    :" + e.Data + Environment.NewLine + "________________________________________________" + Environment.NewLine;



            MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        



        #endregion
    }
}
