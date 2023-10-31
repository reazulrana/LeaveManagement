using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Contacts
    {
        public int ContactID { get; set; }

        public string EmpCode { get; set; }
        public string ContactNo { get; set; }
        public string Operator { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Remarks { get; set; }
        
    }
}
