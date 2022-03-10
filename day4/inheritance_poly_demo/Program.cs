using System;

namespace inheritance_poly_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts accObj = new Accounts();
            accObj.accNo = 101;
            accObj.accName  = "Nik";
            accObj.accBalance = 5000;
            accObj.accIsActive = true;
            accObj.Widraw(200);

            Savings savObj = new Savings();
            savObj.accNo = 201;
            savObj.accName = "Mike";
            savObj.accBalance = 9000;
            savObj.accIsActive = true;

            System.Console.WriteLine("Balance Before Widraw " + savObj.accBalance);
            savObj.Widraw(600);
            System.Console.WriteLine("Balance After Widraw " + savObj.accBalance);

            Loan loanObj = new Loan();
            loanObj.accName = "Pete";
            loanObj.accBalance = 4000;
            loanObj.accIsActive = true;
            loanObj.accNo = 301;
            System.Console.WriteLine("Loan Account Balance " + loanObj.accBalance);

        }
    }
}

