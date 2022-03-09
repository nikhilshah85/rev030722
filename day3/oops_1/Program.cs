using System;

namespace oops_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts accObj1 = new Accounts();
            accObj1.AccountNumber = 101;
            accObj1.AccountName = "Nik";
            accObj1.AccountBalance = 8000;
            accObj1.isAccountActive = true;

            Console.WriteLine("1. Widraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Check Balance");

            bool continueBanking = true;

            while(continueBanking)
            {

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                
                case 1:
                     Console.WriteLine("Balance Before Widrawal " + accObj1.AccountBalance);
                     System.Console.WriteLine("Enter the amount you wish to widraw");
                     int w_amount = Convert.ToInt32(Console.ReadLine());
                     accObj1.Widraw(w_amount);
                     Console.WriteLine("Balance After Widraw : " + accObj1.AccountBalance);
                     break;
                case 2:
                     System.Console.WriteLine(" ---------------------------------------------  ");
                     System.Console.WriteLine("Balance before Deposit " + accObj1.AccountBalance);
                     System.Console.WriteLine("Enter the amount you wish to Deposit");
                      int d_amount = Convert.ToInt32(Console.ReadLine());
                     accObj1.Deposit(d_amount);
                     System.Console.WriteLine("Balance After Deposit " +  accObj1.AccountBalance);
                     break;
                case 3:
                    System.Console.WriteLine("Available Balance is " + accObj1.CheckBalance());
                    break;
                default:
                    System.Console.WriteLine("Sorry Wrong Input");
                    continueBanking = false;
                    break;
            }
            }
           

           


        }
    }
}
