using System;

namespace Polymorphism_exception
{
    class Loan : Account
    {
        public override double Widraw(int w_amount)
        {
           
            return base.Widraw(w_amount);
        }
    }
}