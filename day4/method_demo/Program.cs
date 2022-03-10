using System;

namespace method_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations calObj  = new Calculations();
            // Console.WriteLine(calObj.Add(2,5));

            Console.WriteLine("Enter first Number");
            int num1  = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter first Number");
            int num2  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pass more numbers, Press 0 when done to see the addition");

            int temp = 1;
            int moreNumbers = 0;
            while (temp != 0)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                moreNumbers += temp;               
            }
                
            Console.Clear();
            Console.WriteLine("Addition of All your numbers are " + calObj.Add(num1,num2,moreNumbers));


          
           
            





        }
    }
}
