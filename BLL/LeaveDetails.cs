using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class LeaveDetails
    {
        public int LDID { get; set; }
        public string EmpCode { get; set; }
        public DateTime EntryDate { get; set; }
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeave { get; set; }
        public string ReasonofLeave { get; set; }
        public string FileName { get; set; }
        public byte[] Attachements { get; set; }


    }
}
