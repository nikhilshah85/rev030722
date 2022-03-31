using System;
using System.Collections.Generic;

#nullable disable

namespace LINQ_To_Database.Models.EF.Employee
{
    public partial class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int? EmpSalary { get; set; }
        public bool? EmpIsPermenant { get; set; }
    }
}
