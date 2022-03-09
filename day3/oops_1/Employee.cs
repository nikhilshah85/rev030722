using System;

class Employee
{
    public string empName { get; set; }
    public int empNumber { get; set; }
    public double empSalary { get; set; }
    public bool empIsPermenant { get; set; }
    public int empAvailableLeaves { get; set; }

    public int ApplyLeave(int days)
    {
        empAvailableLeaves = empAvailableLeaves - days;
        return empAvailableLeaves;
    }
}