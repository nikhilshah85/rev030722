using System;
using System.Collections;
using System.Collections.Generic;
namespace Collections_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array

            #region Hardcoded value
            //string[] ListOfAssociates = new string[5];
            //ListOfAssociates[0] = "Art";
            //ListOfAssociates[1] = "Cody";
            //ListOfAssociates[2] = "Darius";
            //ListOfAssociates[3] = "Erick";
            //ListOfAssociates[4] = "Gerome";

            //for (int i = 0; i < ListOfAssociates.Length ; i++)
            //{
            //    Console.WriteLine(ListOfAssociates[i]);
            //}
            #endregion

            #region Runtime Array sizeing

            //Console.WriteLine("How many values you wish to store ?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //string[] associates = new string[count];

            //for (int i = 0; i < associates.Length; i++)
            //{
            //    associates[i] =  Console.ReadLine();
            //}

            //Console.WriteLine("Thank you for All the Names");

            //Console.WriteLine("Total Values recieved : " + associates.Length);

            //for (int i = 0; i < associates.Length; i++)
            //{
            //    Console.WriteLine(associates[i]);
            //}
            #endregion

            #region Integer Arrays
            //what is the total of all the numbers
            //how many are even
            //how many odd
            //how many nigative numbers

            //int[] allNumbers = new int[10];
            //int number = 0;

            //int even = 0;
            //int odd = 0;
            //int negative = 0;
            //int sumOfAllNumber = 0;
            //for (int i = 0; i < allNumbers.Length; i++)
            //{
            //    Console.WriteLine("Enter the Number " + i);
            //    number = Convert.ToInt32(Console.ReadLine());
            //    allNumbers[i] = number;
            //   sumOfAllNumber =sumOfAllNumber + number;
            //    if (number < 0)
            //    {
            //        negative++;
            //    }

            //    if (number % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }

            //}

            //Console.WriteLine("Total Of All Numbers : " + sumOfAllNumber);
            //Console.WriteLine("Even Numbers : " + even);
            //Console.WriteLine("Odd Numbers : " + odd);
            //Console.WriteLine("Negative Numbers : " + negative);

            #endregion

            #region Array or Objects - Old lengthy way

            //Employee[] empList = new Employee[5];
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();
            //Employee emp3 = new Employee();
            //Employee emp4 = new Employee();
            //Employee emp5 = new Employee();

            //emp1.empNo = 101;
            //emp1.empName = "Nik";
            //emp1.empDesignation = "Trainer";
            //emp1.empSalary = 2;
            //emp1.empIsPermenant = true;

            //emp2.empNo = 102;
            //emp2.empName = "Josh";
            //emp2.empDesignation = "HR";
            //emp2.empSalary = 5;
            //emp2.empIsPermenant = false;

            //emp3.empNo = 102;
            //emp3.empName = "Josh";
            //emp3.empDesignation = "HR";
            //emp3.empSalary = 5;
            //emp3.empIsPermenant = false;

            //emp4.empNo = 102;
            //emp4.empName = "Josh";
            //emp4.empDesignation = "HR";
            //emp4.empSalary = 5;
            //emp4.empIsPermenant = false;

            //emp5.empNo = 102;
            //emp5.empName = "Josh";
            //emp5.empDesignation = "HR";
            //emp5.empSalary = 5;
            //emp5.empIsPermenant = false;

            //empList[0] = emp1;
            //empList[1] = emp2;
            //empList[2] = emp3;
            //empList[3] = emp4;
            //empList[4] = emp5;

            //int sumOfPermenant = 0;
            //double sumOfSalary = 0;
            //for (int i = 0; i < empList.Length; i++)
            //{
            //    Console.WriteLine(empList[i].empNo);
            //    Console.WriteLine(empList[i].empName);
            //    Console.WriteLine(empList[i].empDesignation);
            //    Console.WriteLine(empList[i].empSalary);
            //    Console.WriteLine(empList[i].empIsPermenant);
            //    Console.WriteLine("--------------------------------------------------------");
            //    sumOfSalary = sumOfSalary + empList[i].empSalary;
            //    if (empList[i].empIsPermenant)
            //    {
            //        sumOfPermenant++;
            //    }
            //}

            //Console.WriteLine("Total Salary Paid " + sumOfSalary);
            //Console.WriteLine("Total Employees : " + empList.Length);
            //Console.WriteLine("Permenant Employees : " + sumOfPermenant);
            //Console.WriteLine("Contact Employes : "  + (empList.Length - sumOfPermenant));

            #endregion

            #region Array of Object - Object Initilizer

            //Employee emp1 = new Employee() { empNo =101, empDesignation ="Consultant", empIsPermenant =true, empName="Mike", empSalary=2500};
            //Employee emp2 = new Employee() { empNo =102, empDesignation="HR", empIsPermenant=false, empName="Riya", empSalary=6300 };
            //Employee emp3 = new Employee() { empNo =103, empDesignation="HR", empIsPermenant=false, empName="Riya", empSalary=6300 };
            //Employee emp4 = new Employee() { empNo =104, empDesignation="HR", empIsPermenant=false, empName="Riya", empSalary=6300 };
            //Employee emp5 = new Employee() { empNo =105, empDesignation="HR", empIsPermenant=false, empName="Riya", empSalary=6300 };
            //Employee[] empList = new Employee[5] {emp1, emp2, emp3, emp4, emp5 };

            //int sumOfPermenant = 0;
            //double sumOfSalary = 0;
            //for (int i = 0; i < empList.Length; i++)
            //{
            //    Console.WriteLine(empList[i].empNo);
            //    Console.WriteLine(empList[i].empName);
            //    Console.WriteLine(empList[i].empDesignation);
            //    Console.WriteLine(empList[i].empSalary);
            //    Console.WriteLine(empList[i].empIsPermenant);
            //    Console.WriteLine("--------------------------------------------------------");
            //    sumOfSalary = sumOfSalary + empList[i].empSalary;
            //    if (empList[i].empIsPermenant)
            //    {
            //        sumOfPermenant++;
            //    }
            //}

            //Console.WriteLine("Total Salary Paid " + sumOfSalary);
            //Console.WriteLine("Total Employees : " + empList.Length);
            //Console.WriteLine("Permenant Employees : " + sumOfPermenant);
            //Console.WriteLine("Contact Employes : "  + (empList.Length - sumOfPermenant));


            #endregion




            #endregion

            #region Array drawbacks

            //            Array

            //    1. if you declare an array type, you have to store the same data type

            //    eg. string[] names = new string[5];

            //            you cannot store numbers and booleans "10"


            //    we need to store multiple datatypes under 1 variable, we dont know what it will be


            //    2.Size

            //        string[] names = new string[5];
            //            u can store only 5 values


            //        you need to be properly aware of your data

            //Arraylist instead -not need to worry about size or datatype, completely dynamic

            #endregion

            #region ArrayList

            //ArrayList myList = new ArrayList();
            //myList.Add(10);
            //myList.Add(20);
            //myList.Add("Nik");
            //myList.Add(true);
            //myList.Add(new Employee() { empNo=101, empName="Sam", empDesignation="HR", empIsPermenant=true, empSalary=6000 });
            //myList.Add(10.2);
            //myList.Add("Sales");

            ////keep adding the values as many as you want to
            ////keep adding any kind of data as per your need

            //Console.WriteLine(myList.Count);

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region List         

            //List<string> friends = new List<string>();
            //friends.Add("Mike");
            //friends.Add("Karan");
            //friends.Add("Mohan");
            //friends.Add("Roy");
            //foreach (var item in friends)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){empNo=101, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=102, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=103, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=104, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=105, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=106, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=107, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=108, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=109, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=110, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=111, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=112, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //    new Employee(){empNo=113, empName="Priya", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            //};

            //employees.Add(new Employee() { empNo=114})

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.empNo);
            //    Console.WriteLine(item.empName);
            //    Console.WriteLine(item.empDesignation);
            //    Console.WriteLine(item.empIsPermenant);
            //    Console.WriteLine(item.empSalary);
            //    Console.WriteLine("_---------------------------------------");
            //}
            #endregion

            #region HashTable
            //Hashtable ht = new Hashtable();
            //ht.Add()
            //ht.Add(1, "Nikhil");
            //ht.Add(2, "Nikky");
            //ht.Add(3, "Nikita");
            //ht.Add(4, "Nimish");
            //ht.Add("Jade", "Marshal");
            //ht.Add(true, 10.20);
            //ht[3] = "Cody";

            //keys cannot be repeated

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary

            //Dictionary<int,string> guestlist = new Dictionary<int,string>();
            //guestlist.Add(1, "Nikhil");
            //guestlist.Add(12, "Sam");
            //guestlist.Add(18, "Mike");
            //guestlist.Add(10, "Mike");
            //guestlist.Add(2, "Mike");
            //guestlist.Add(3, "Mike");
            //guestlist.Add(3, "Mike");
            //guestlist.Add(5, "Mike");
            //guestlist.Add(6, "Mike");
            //guestlist.Add(7, "Mike");
            //guestlist.Add(8, "Mike");

            //foreach (var item in guestlist)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            #endregion

            #region Sorted Dictionary
            //SortedDictionary<int,string> dictionary = new SortedDictionary<int,string>();
            //dictionary.Add(1, "Niki");
            //dictionary.Add(100, "Niki");
            //dictionary.Add(2, "Niki");
            //dictionary.Add(4, "Niki");
            //dictionary.Add(3, "Niki");
            //dictionary.Add(150, "Niki");
            //dictionary.Add(5, "Niki");
            //dictionary.Add(125, "Niki");
            //dictionary.Add(190, "Niki");
            //dictionary.Add(6, "Niki");
            //dictionary.Add(7, "Niki");
            //dictionary.Add(200, "Niki");
            //dictionary.Add(9, "Niki");
            //dictionary.Add(11, "Niki");


            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            #endregion




        }
    }
}
