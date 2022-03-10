using System;

namespace Polymorphism_exception
{
    class  Account
    {
        public double accBalance { get; set; }
        public string accName { get; set; }

        public virtual double Widraw(int w_amount)
        {

            if(w_amount < 0)
            {
                //throw the exception
                throw new Exception("Please Enter Postitive Value");
            }
            else if(w_amount > accBalance)
            {
                throw new Exception("Insufficient Balance");
            }
            else if(w_amount == 0)
            {
                throw new Exception("Enter Amount more than Zero");
            }
            accBalance = accBalance - w_amount;
            return accBalance;
        }
    }
}