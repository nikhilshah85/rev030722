using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] particapants = new string[5];
            // // int[] scores = new int[5];

            // particapants[0] = "Lavie";
            // particapants[1] = "Roger";
            // particapants[2] = "Shane";
            // particapants[3] = "Cody";
            // particapants[4] = "Art";


            // Console.WriteLine(particapants[3]);

        // string[] friends = new string[5];
        //     for(int i=0; i < 5; i++)
        //     {
        //             Console.WriteLine("Enter Friend " + i);
        //             friends[i] =  Console.ReadLine();
        //     }

        //         Console.Clear();
        //     for(int i=0;i < 5 ;i++)
        //     {
        //             Console.WriteLine("Dear. " + friends[i]);
        //     }


            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter Number " + (i + 1));
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            int sum_of_numbers = 0;
            int total_even_numbers = 0;
            int total_odd_numbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum_of_numbers += numbers[i];
                if(numbers[i] % 2 == 0)
                {
                    total_even_numbers += 1;
                    
                }
                else
                {
                    total_odd_numbers+=1;
                }
            }


            Console.WriteLine("Total of all your numbers are " + sum_of_numbers);
            Console.WriteLine("Total Even Numbers are " + total_even_numbers);
            Console.WriteLine("Total Odd Numbers are " + total_odd_numbers);






        }
    }
}
