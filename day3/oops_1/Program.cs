using System;

namespace oops_1
{
    class Program
    {
        static void Main(string[] args)
        {
          

         #region Old Way to create an Object
            // Employee empObj1 = new Employee();
            // empObj1.empNumber = 101;
            // empObj1.empName = "Nik";
            // empObj1.empSalary = 5000;
            // empObj1.empIsPermenant = true;
            // empObj1.empAvailableLeaves = 20;

//new Way (C# 3.0 onwards)
        // Employee empObj = new Employee()
        // { 
        //     empNumber =101,
        //     empName ="Nikhil",
        //     empSalary=2000,
        //     empIsPermenant = true,
        //     empAvailableLeaves = 40
        // };

#endregion
          
          #region Account Objects
            Accounts accObj1 = new Accounts();
            accObj1.AccountNumber = 101;
            accObj1.AccountName = "Nik";
            accObj1.AccountBalance = 8000;
            accObj1.isAccountActive = true;
          
          
            Accounts accObj2 = new Accounts();
            accObj2.AccountNumber = 102;
            accObj2.AccountName = "Mike";
            accObj2.AccountBalance = 4000;
            accObj2.isAccountActive = true;
        #endregion
       
          #region Menu
       
            Console.WriteLine("1. Widraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Check Balance");
        #endregion
          bool continueBanking = true;

        #region While Loop menu
            while(continueBanking)
            {

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                #region 1. Widrawal

                case 1:
                     Console.WriteLine("Balance Before Widrawal " + accObj1.AccountBalance);
                     System.Console.WriteLine("Enter the amount you wish to widraw");
                     int w_amount = Convert.ToInt32(Console.ReadLine());
                     accObj1.Widraw(w_amount);
                     Console.WriteLine("Balance After Widraw : " + accObj1.AccountBalance);
                     break;
                #endregion
                #region 2. Deposit
                
                case 2:
                     System.Console.WriteLine(" ---------------------------------------------  ");
                     System.Console.WriteLine("Balance before Deposit " + accObj1.AccountBalance);
                     System.Console.WriteLine("Enter the amount you wish to Deposit");
                      int d_amount = Convert.ToInt32(Console.ReadLine());
                     accObj1.Deposit(d_amount);
                     System.Console.WriteLine("Balance After Deposit " +  accObj1.AccountBalance);
                     break;
                #endregion
               #region  3. Check Balance
                case 3:
                    System.Console.WriteLine("Available Balance is " + accObj1.CheckBalance());
                    break;
                #endregion
              #region  Default Other Option and exite
                default:
                    System.Console.WriteLine("Sorry Wrong Input");
                    continueBanking = false;
                    break;
                #endregion
            }
            }
           

           #endregion


        }
    }
}
