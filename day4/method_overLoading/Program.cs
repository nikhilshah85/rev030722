using System;



Calculations calObj = new Calculations();
int addResult  = calObj.Add(20,30);

Console.WriteLine(" 2 Numbers Addition " + addResult);
Console.WriteLine(" 3 Numbers Addition " + calObj.Add(30,30,30));
Console.WriteLine(" 4 Numbers Addition " + calObj.Add(30,30,30,40));
Console.WriteLine(" 2 Doubles Addition " + calObj.Add(310.5,60.65));