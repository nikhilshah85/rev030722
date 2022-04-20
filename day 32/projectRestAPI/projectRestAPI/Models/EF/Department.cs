using System;
using System.Collections.Generic;

namespace projectRestAPI.Models.EF
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string? DeptName { get; set; }
        public string? DeptLocation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
