using System;


class Calculations
{

    public int Add(int num1 = 0, int num2 = 0, params int[] moreNumbers)
    {
        int temp = 0;
        for (int i = 0; i < moreNumbers.Length ; i++)
        {
            temp += moreNumbers[i];
        }
        return num1 + num2 + temp;
    }




    // public int Add(int num1, int num2)
    // {
    //     return num1 + num2;
    // }

    // public double Add(double num1, double num2)
    // {
    //     return num1 + num2;
    // }

    // public int Add(int num1, int num2, int num3)
    // {
    //     return num1 + num2 + num3;
    // }

    // public int Add(int num1, int num2, int num3, int num4)
    // {
    //     return num1 + num2 + num3 + num4;
    // }
}