using System;

namespace inheritance_poly_demo
{
    class Program
    {
        static void Main(string[] args)
        {
          
          #region Inheritance


          //This is not the right thing to do
          //We do not wish an object of Accounts to be created by our software
            // Accounts accObj = new Accounts();
            // accObj.accNo = 101;
            // accObj.accName  = "Nik";
            // accObj.accBalance = 5000;
            // accObj.accIsActive = true;
            // accObj.Widraw(200);

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
            #endregion


        Savings sav = new Savings();
        Loan loan = new Loan();
        Checking chk = new Checking();

        System.Console.WriteLine(sav.WhoAmI());
        System.Console.WriteLine(loan.WhoAmI());
        System.Console.WriteLine(chk.WhoAmI());

        }
    }
}

