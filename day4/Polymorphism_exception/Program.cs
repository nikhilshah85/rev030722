using System;

namespace Polymorphism_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings sav = new Savings();
            sav.accName = "Nik";
            sav.accBalance = 25000;

            Checking chk = new Checking();
            chk.accName = "Niki";
            chk.accBalance = 25000;

            Loan ln = new Loan();
            ln.accName = "Micky";
            ln.accBalance = 25000;

            bool continueBanking = true;

            while (continueBanking)
            {               
            

            try
            {
                //  System.Console.WriteLine("Savings " + sav.Widraw(35000));
                //  System.Console.WriteLine("Checking " + chk.Widraw(20000));
                //  System.Console.WriteLine("Loan " + ln.Widraw(80000));

                System.Console.WriteLine("Please Enter Amount to Widraw");
                int amount_to_widraw =Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine(ln.Widraw(amount_to_widraw));


            }
            catch (Exception es)
            {
                System.Console.WriteLine(es.Message);
                
            }
            finally
            {
                
            System.Console.WriteLine("You Want to try Again ?, Press 1 ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice != 1)
            {
                continueBanking = false;
            }
            }

  
           
            }


        }
    }
}
