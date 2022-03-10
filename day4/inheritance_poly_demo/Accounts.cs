using System;

namespace inheritance_poly_demo
{
    class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }

        public double Widraw(int w_amount)
        {
            accBalance = accBalance - w_amount;
            return accBalance;
        }

        public double Deposit(int d_amount)
        {
            accBalance = accBalance + d_amount;
            return accBalance;
        }

        public string WhoAmI()
        {
            return "I am Parent - (Accounts)";
        }


    }

}