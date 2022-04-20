using System;
using System.Collections.Generic;

namespace projectRestAPI.Models.EF
{
    public partial class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpDesignation { get; set; } = null!;
        public int EmpSalary { get; set; }
        public int EmpAge { get; set; }
        public string EmpSsn { get; set; } = null!;
        public int? EmpDept { get; set; }

        public virtual Department? EmpDeptNavigation { get; set; }
    }
}
