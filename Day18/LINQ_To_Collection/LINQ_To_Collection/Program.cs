using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ_To_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var eList = new List<Employee>()
            { 
                new Employee() { empNo=101, empName="Mike", empDesignation="Sales", empIsPermenant=true, empSalary=6000},
                new Employee() { empNo=102, empName="Jorge", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
                new Employee() { empNo=103, empName="Donald", empDesignation="Accounts", empIsPermenant=false, empSalary=12000},
                new Employee() { empNo=104, empName="Willian", empDesignation="Sales", empIsPermenant=true, empSalary=18000},
                new Employee() { empNo=105, empName="John", empDesignation="Sales", empIsPermenant=true, empSalary=630},
                new Employee() { empNo=106, empName="Tiger woods", empDesignation="Accounts", empIsPermenant=true, empSalary=150000},
                new Employee() { empNo=107, empName="Will smith", empDesignation="Developer", empIsPermenant=false, empSalary=19500},
                new Employee() { empNo=108, empName="Britney", empDesignation="Sales", empIsPermenant=true, empSalary=18900},
                new Employee() { empNo=109, empName="Ruth", empDesignation="Sales", empIsPermenant=true, empSalary=26300},
                new Employee() { empNo=110, empName="Dwayne Johnson", empDesignation="Accounts", empIsPermenant=false, empSalary=2600},
                new Employee() { empNo=111, empName="Undertaker", empDesignation="Developer", empIsPermenant=true, empSalary=78000},
                new Employee() { empNo=112, empName="Kane", empDesignation="Accounts", empIsPermenant=true, empSalary=61000},
                new Employee() { empNo=113, empName="Hulk Hogan", empDesignation="Sales", empIsPermenant=false, empSalary=25000},
                new Employee() { empNo=114, empName="Goldman", empDesignation="Sales", empIsPermenant=true, empSalary=15000},
                new Employee() { empNo=115, empName="Batishta", empDesignation="Developer", empIsPermenant=true, empSalary=36000},
                new Employee() { empNo=116, empName="Bruse", empDesignation="Sales", empIsPermenant=false, empSalary=85000},
                new Employee() { empNo=117, empName="Triple-H", empDesignation="Developer", empIsPermenant=true, empSalary=160000},
                new Employee() { empNo=118, empName="Benjamin", empDesignation="Sales", empIsPermenant=true, empSalary=16000},
                new Employee() { empNo=119, empName="Lucas", empDesignation="Sales", empIsPermenant=true, empSalary=26000},
                new Employee() { empNo=120, empName="Peter Parker", empDesignation="Sales", empIsPermenant=true, empSalary=36000},
                new Employee() { empNo=121, empName="Aunt May", empDesignation="Sales", empIsPermenant=true, empSalary=63000},
                new Employee() { empNo=122, empName="Marry jane", empDesignation="Sales", empIsPermenant=true, empSalary=168000},

            };

            #region select * from source

            ////this is equal to select * from source
            //var emp = from em in eList 
            //          select em;
            ////sort, filter, calulate, columns, validate, group


            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.empName);
            //}
            #endregion

            #region where clause
            //var developers = from em in eList
            //                 where em.empDesignation == "Developer"
            //                 select em;

            //foreach (var item in developers)
            //{
            //    Console.WriteLine(item.empNo + " " +  item.empName + " " + item.empDesignation);
            //}
            #endregion

            #region Order by clause - Sort the data
            //var emp = from em in eList
            //          orderby em.empDesignation,em.empName descending
            //          select em;

            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.empNo + " " + item.empName + " " + item.empDesignation);
            //}
            #endregion

            #region Where and order by
            //var emp = from em in eList
            //          where em.empSalary > 50000
            //          orderby em.empSalary descending
            //          select em;
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.empName + " " + item.empSalary);
            //}
            #endregion

            #region select limited col and do calculation

            //var emp = from em in eList
            //          select new
            //          {
            //              FirstName = em.empName,
            //              Salary = em.empSalary,
            //              Bonus = em.empSalary * 0.1,
            //              WorksAs = em.empDesignation
            //          };

            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.WorksAs);
            //    Console.WriteLine(item.Salary + " " + item.Bonus);
            //    Console.WriteLine("--------------");
            //}
            #endregion

            #region Aggregation
            //  var totalEmp = (from e in eList
            //                  select e).Count();


            //  var sumOfSalary = (from e in eList
            //                     select e.empSalary).Sum();

            //  var minSalary = (from e in eList
            //                   select e.empSalary).Min();

            //  var maxSalary = (from e in eList
            //                   select e.empSalary).Max();

            //  var avgSal = (from e in eList
            //                select e.empSalary).Average();


            //  var sumOfdevelopersal = (from e in eList
            //                           where e.empDesignation == "Developer"
            //                           select e.empSalary).Sum();

            //Console.WriteLine("Total Employees are : " + totalEmp);
            //  Console.WriteLine("Total Salary Paid : "+ sumOfSalary);
            //  Console.WriteLine("Minimum Salary Paid : "+ minSalary);
            //  Console.WriteLine("Maximum Salary Paid : "+ maxSalary);
            //  Console.WriteLine("Average Salary Paid : "+ avgSal);
            //  Console.WriteLine("Develpers Sal : " + sumOfdevelopersal);
            #endregion

            #region String function
            //var emp = from em in eList
            //          where em.empName.Contains("D")
            //          select em;

            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.empNo + " " + item.empName);
            //}
            #endregion

            #region Lambda express with fat Arrow

            //var totalSal = eList.Sum(e => e.empSalary);
            //Console.WriteLine(totalSal);

            //var emp = eList.Where(e => e.empName == "Donald");
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.empNo + " " + item.empName);
            //}

            //int em = eList.RemoveAll(e => e.empDesignation == "Sales");
            //Console.WriteLine("Removed " + em);

            //var count = eList.Count;
            //Console.WriteLine("Total Left " + count);

            #endregion

        }
    }
}
