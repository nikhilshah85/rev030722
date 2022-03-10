using System;

namespace Polymorphism_exception
{
    class Savings : Account
    {
        public override double Widraw(int w_amount)
        {
            if (w_amount > 5000)
            {
               throw new Exception("You Cannot widraw more than 5000");
            }
            else
            {
              return  base.Widraw(w_amount);
            }
        }
    }
}