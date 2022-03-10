using System;
namespace inheritance_poly_demo
{
    class Checking: Accounts
    {
        public override string WhoAmI()
        {
            return "I am Child of Account - Checking";
        }

    }
}