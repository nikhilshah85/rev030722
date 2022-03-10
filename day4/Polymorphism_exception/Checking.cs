using System;

namespace Polymorphism_exception
{
    class Checking : Account
    {
          public override double Widraw(int w_amount)
        {
            if (w_amount > 15000)
            {
               throw new Exception("You Cannot widraw more than 15000");
            }
            else
            {
               return  base.Widraw(w_amount);
            }
        }
    }
}