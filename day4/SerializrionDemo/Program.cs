using System;

namespace SerializrionDemo
{
    class Program
    {
        static void Main(string[] args)
        {


                System.Console.WriteLine(" ~~~~~~~~~~  Welcome to Banking ~~~~~~~~~~~~~~~");
                System.Console.WriteLine("1. Create New Account");
                System.Console.WriteLine("2. Check Account Details");
                System.Console.WriteLine("3. Widraw");
                System.Console.WriteLine("4. Deposit");
                System.Console.WriteLine("5. Transfer");
                System.Console.WriteLine("6. Exit");

                bool continueBanking = true;

                while (continueBanking)
                {
                    
                Console.Clear();
                System.Console.WriteLine(" ~~~~~~~~~~  Welcome to Banking ~~~~~~~~~~~~~~~");
                System.Console.WriteLine("1. Create New Account");
                System.Console.WriteLine("2. Check Account Details");
                System.Console.WriteLine("3. Widraw");
                System.Console.WriteLine("4. Deposit");
                System.Console.WriteLine("5. Transfer");
                System.Console.WriteLine("6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                      #region  Create new Account
            Accounts accObj = new Accounts();
            System.Console.WriteLine("Enter Account Number");
            accObj.accNo = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Account Name");
            accObj.accName =  Console.ReadLine();

            System.Console.WriteLine("Enter Account Balance");
            accObj.accBalance =Convert.ToDouble(Console.ReadLine());


            accObj.accIsActive = true;

            System.Console.WriteLine("Enter Account Type");
            accObj.accType = Console.ReadLine();

            System.Console.WriteLine("Enter Account Email");
            accObj.accEmail = Console.ReadLine();

            accObj.SaveObject();
        

            #endregion
                      break;
                    case 2:
                        #region Check Details
            Accounts acc = new Accounts();
            Console.WriteLine("Enter the Account Number");
            int account = Convert.ToInt32(Console.ReadLine());
            acc = acc.GetObject(account);
            System.Console.WriteLine(acc.accName);
            System.Console.WriteLine(acc.accBalance);
            System.Console.WriteLine(acc.accType);
            System.Console.WriteLine(acc.accIsActive);
            System.Console.WriteLine(acc.accEmail);
          
        #endregion
                        break;
                    case 3:
                        break;              
                    default:
                        continueBanking = false;
                        break;
                }
                System.Console.WriteLine("\n \n Press enter to continue");
                    Console.ReadLine();
            
          


         
                }

        }
    }
}
