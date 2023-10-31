using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Data.SqlClient;
namespace DAL
{
    public interface IDataConnection
    {



        #region "Start Create Methods Section"



        void CreateEmployee(Personal model);
        void CreateLeaveDetails(LeaveDetails model);
        void CreateContacts(Contacts model);
        void CreateNidDetails(NIDDetails model);
        void CreateUser(Users model);
        void CreateMail(MailList model);




        #endregion



        #region "Start Update Methods Section"


        void UpdateEmployee(Personal model);
        void UpdateLeaveDetails(LeaveDetails model);
        void UpdateContacts(Contacts model);
        void UpdateNIDDetailsByNidID(NIDDetails model);
        void UpdateUser(Users model);
        void UpdateMail(MailList model);


        #endregion





        #region "Start Delete Methods Section"


        void DeleteEmployee(string EmpCode);
        void DeleteLeaveDetailsByID(int id);
        void DeleteContact(int id);
        void DeleteNIDDetails(int id);
        void DeleteUser(int UID);
        void DeleteMail(int mailid);



        #endregion




        #region "Start Get Methods Section"

        #region "Employee Section"
        List<Personal> GetAllEmployee { get; }
        List<Personal> GetAllEmployees(DateTime StartDate, DateTime EndDate);
        Personal GetEmployeeByEmpCode(string empcode);
        #endregion



        #region "LeaveDetails Section"


        List<LeaveDetails> GetLeaveDetailsbyCode(string Code);
        List<LeaveDetails> GetLeaveDetailsbyDate(string Code, DateTime StartDate, DateTime EndDate);

        List<LeaveDetailsExtraInfo> GetLeaveDetailsExtraInfo(DateTime fromdate, DateTime todate);
        #endregion



        #region "Contact Section"

        List<Contacts> GetContactByEmpCode(string EmpCode);


        List<ContactExtraInfo> GetContactExtrainfo { get; }
        #endregion




        #region "Nid Details"

        List<NIDDetails> GetNIDDetailsbyEmpCode(string empcode);
        List<NidDetailsExtraInfo> GetNIDDetailsExtrainfo { get; }

        #endregion


        #region "User Information Section"

        List<Users> GetAllUser { get; }

        #endregion

        #region "Mail Section"
        List<MailList> GetMailByPerson(string empcode);
        List<MailList> GetAllMail();
        #endregion

        string GetDatabaseName { get; }

        #endregion



        #region "User Information Section"
        Users UserVerify(Users model);
        #endregion


        #region "Database Back up Section"

        void BackupDatabase(BackUp model);

        //Check Database IsExist or not By Connection to the database
        bool CheckDatabaseExistng { get; }

        #endregion



        #region "Start Error Section"

        void ErrorMessage(Exception e);

        //Check Database IsExist or not By Connection to the database


        #endregion






    }
}
