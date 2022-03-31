using System;
using System.Collections.Generic;

#nullable disable

namespace LINQ_To_Database.Models.EF.Employee
{
    public partial class ContactInfo
    {
        public int? EmpNo { get; set; }
        public string EmpEmail { get; set; }
        public long? EmpCellNo { get; set; }
        public long? EmpEmergencyContact { get; set; }
        public string EmpLinkedInProfile { get; set; }
        public string EmpAddress { get; set; }

        public virtual EmployeeInfo EmpNoNavigation { get; set; }
    }
}
