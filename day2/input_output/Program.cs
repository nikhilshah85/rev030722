using System; 

namespace input_output
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~ Welcome to Banking APP ~~~~~~~~~~~~~~~~~~~~~~~~~~");
           
            // Console.WriteLine("Please Enter your First Name");
            // string v_guestName =    Console.ReadLine();
           
            // Console.WriteLine("Please Enter your last name");
            // string v_guestLastName = Console.ReadLine();

            // System.Console.WriteLine("Thank You " + v_guestName + " " + v_guestLastName);

            // Console.WriteLine("Enter First Number ");
            // int v_firstNum =Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter Second Number");
            // int v_secondNum = Convert.ToInt32(Console.ReadLine());

            // int addition = v_firstNum + v_secondNum;
            // int subtraction = v_firstNum - v_secondNum;
            // int multiplication = v_firstNum * v_secondNum;
            // int division = v_firstNum / v_secondNum;

            // System.Console.WriteLine("Addition of your Numbers are " + addition);
            // System.Console.WriteLine("Subtraction of your Numbers are " + subtraction);
            // System.Console.WriteLine("Multiplication of your Numbers are " + multiplication);
            // System.Console.WriteLine("division of your Numbers are " + division);



            // Console.WriteLine("Enter A Number to get the review");
            // int v_Number = Convert.ToInt32(Console.ReadLine());

            // if (v_Number < 0)
            // {
            //     Console.WriteLine("This is a Negative number");
            // }
            // else if(v_Number > 0 && v_Number < 5)
            // {
            //     Console.WriteLine("Average Number");
            // }
            // else if(v_Number > 5 && v_Number < 10)
            // {
            //     System.Console.WriteLine("Good Number");                
                
            // }
            // else if(v_Number > 10 && v_Number < 20)
            // {
            //     System.Console.WriteLine("Very good Number");
            // }
            // else if(v_Number > 20)
            // {
            //     System.Console.WriteLine("Excellent Number");
            // }
            // else
            // {
            //     System.Console.WriteLine("Something went wrong, please try again later");
            // }



            Console.WriteLine("Tell me something about your self");

            string info = "";
            string detail = "";

            while (info != "Thank You")
            {       
                info =  Console.ReadLine();
                detail = detail + " " + info;
                // detail += info; //short hand
                
            }
            Console.Clear();
            Console.WriteLine(detail);
                











        }
    }
}
