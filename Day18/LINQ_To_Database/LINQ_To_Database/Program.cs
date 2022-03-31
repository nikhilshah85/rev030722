using System;
using LINQ_To_Database.Models.EF.Employee;
using System.Linq;
namespace LINQ_To_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new employeeManagementContext();

            #region select * 
            //var employees = from em in emp.EmployeeInfos
            //                select em;

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.EmpNo + " " + item.EmpName);
            //}
            #endregion

            #region Filter data
            //var employees = from em in emp.EmployeeInfos
            //                where em.EmpDesignation == "Developer"
            //                select em;

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.EmpName);
            //}

            #endregion

            #region Joins

            //var employee = from em in emp.EmployeeInfos
            //               join
            //               ci in emp.ContactInfos on em.EmpNo equals ci.EmpNo
            //               select new
            //               {
            //                   Name = em.EmpName,
            //                   Designation = em.EmpDesignation,
            //                   Email = ci.EmpEmail,
            //                   Emergency = ci.EmpEmergencyContact,
            //                   Address = ci.EmpAddress
            //               };

            //foreach (var item in employee)
            //{
            //    Console.WriteLine(item.Name + " " + item.Email + "  " + item.Address);
            //}
            #endregion

            #region Search Employee

            //Console.WriteLine("Enter Employee Number");
            //var eNo = Convert.ToInt32(Console.ReadLine());

            //var empDetails = from e in emp.EmployeeInfos
            //                 where e.EmpNo == eNo
            //                 select e;

            //foreach (var item in empDetails)
            //{
            //    Console.WriteLine("Employee Number : " + item.EmpNo);
            //    Console.WriteLine("Employee Name : " + item.EmpName);
            //    Console.WriteLine("Employee Salary : " + item.EmpSalary);
            //    Console.WriteLine("Employee Is Permenant : " + item.EmpIsPermenant);
            //    Console.WriteLine("Employee Designation : " + item.EmpDesignation);
            //}
            #endregion

            #region Delete Employee
            //Console.WriteLine("Enter Employee Number");
            //var eNo = Convert.ToInt32(Console.ReadLine());

            //EmployeeInfo employeeToDelete = (from e in emp.EmployeeInfos
            //                       where e.EmpNo == eNo
            //                       select e).Single();

            //emp.EmployeeInfos.Remove(employeeToDelete);
            //emp.SaveChanges();
            //Console.WriteLine("Employee Deleted Successfully");
            #endregion

            #region Insert Employee
            //var newEmp = new EmployeeInfo()
            //{
            //    EmpNo = 151,
            //    EmpName = "Julian",
            //    EmpSalary = 300000,
            //    EmpIsPermenant = true,
            //    EmpDesignation = "Janiator"
            //};

            //emp.EmployeeInfos.Add(newEmp);
            //emp.SaveChanges();

            //Console.WriteLine("Employee Added to System");
            #endregion

            #region Update

            //var employee = (from e in emp.EmployeeInfos
            //                where e.EmpNo == 1010
            //                select e).Single();

            //employee.EmpSalary = 800000;
            //employee.EmpDesignation = "Chairman";

            //emp.SaveChanges();

            //Console.WriteLine("Employee Updated");
            #endregion
        }
    }
}


