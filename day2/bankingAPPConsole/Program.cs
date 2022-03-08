using System;

namespace bankingAPPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           

           bool continueBanking = true;

    while(continueBanking)
    {
        Console.Clear();
         System.Console.WriteLine("~~~~~~~~~~~~ Welcome to my Bank");
            System.Console.WriteLine("1. Open New Account");
            System.Console.WriteLine("2. Transfer Funds");
            System.Console.WriteLine("3. Pay Bills");
            System.Console.WriteLine("4. Check Last 5 Transactions");
            System.Console.WriteLine("5. Check Current Balance");
            System.Console.WriteLine("6. Exit");
           int choice = Convert.ToInt32(Console.ReadLine());
          
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Account Opened for you");
                    break;
                case 2:
                    Console.WriteLine(" Fund transfer process initiated");
                    break;
                case 3:
                    Console.WriteLine("Bill Payment in progress !!");
                    break;
                case 4:
                    System.Console.WriteLine("Here are a list of your last 5 transactions");
                    break;
                case 5:
                    System.Console.WriteLine("Your current Balance is 25000");
                    break;
                case 6:
                    System.Console.WriteLine("Thank you for banking with us, see you soon again");
                    continueBanking = false;
                    break;                
                default:
                    System.Console.WriteLine("Sorry that was not a correct option");
                    break;
            }

    }


        }
    }
}
