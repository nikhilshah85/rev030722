using System;

namespace singleTon_demo
{
    class Accounts
    {

        static int autoNumber;
        public int accNo { get; set; }
        public string accName { get; set; } 
        public double accBalance { get; set; }
        public string accType { get; set; }

        public Accounts()
        {
                autoNumber++; //increment the number
                accNo = autoNumber; //allocate the number to accNo property
        }

        public double Widraw(int amount)
        {
            accBalance = accBalance - amount;
            return accBalance;
        }

         public double Deposit(int amount)
        {
            accBalance = accBalance + amount;
            return accBalance;
        }

    }
}