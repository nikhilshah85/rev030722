using System;
namespace inheritance_poly_demo
{
    class Loan : Accounts
    {
        public override string WhoAmI()
        {
            return "I am Child of Acocunts - Loan";
        }
    }
}