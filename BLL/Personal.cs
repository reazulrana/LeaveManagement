using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Personal
    {

        public int EmpID { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public string Branch { get; set; }
        public string Qualification { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AppointDate { get; set; }
        public string NIDNumber { get; set; }
        public DateTime? IDAssignDate { get; set; }
        public string BloodGruop { get; set; }
        public DateTime? JoiningDate { get; set; }
        public byte[] Photo { get; set; }

        public int TotalCL { get; set; }
        public int TotalPL { get; set; }
        public int TotalSL { get; set; }
        public int TotalLWP { get; set; }
        public int Advance { get; set; }
        public int Maternity { get; set; }

        
        public int RemainingCL { get; set; }
        public int RemainingPL { get; set; }
        public int RemainingSL { get; set; }


        public List<LeaveDetails> leavedetails = new List<LeaveDetails>();
        public List<Contacts> ContactList = new List<Contacts>();
        public List<NIDDetails> NIDList = new List<NIDDetails>();
        public List<MailList> MailList = new List<MailList>();
    }
}
