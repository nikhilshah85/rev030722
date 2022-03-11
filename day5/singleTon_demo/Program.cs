using System;

namespace singleTon_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to banking");
            Console.Clear();
            bool continueBanking = true;
            while(continueBanking)
            {

            System.Console.WriteLine("Enter Account Name");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Account Type");
            string type = Console.ReadLine();

            System.Console.WriteLine("Enter Account Balance");
            double bal = Convert.ToInt32(Console.ReadLine());

            Accounts acc = new Accounts();
            acc.accName = name;
            acc.accBalance = bal;
            acc.accType = type;

            System.Console.WriteLine("Account Created New Account No is " + acc.accNo);
            Console.ReadLine();
            }


        }
    }
}
