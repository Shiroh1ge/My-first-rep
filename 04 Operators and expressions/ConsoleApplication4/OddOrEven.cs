using System;
//Write an expression that checks if given integer is odd or even. Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false

class OddOrEven
{
    static void Main()
    {
       // int a = int.Parse(Console.ReadLine());
       // if (a % 2 == 0)
       // {
      //      Console.WriteLine("The number is even");
      //  }
      //  else 
       // {
      //      Console.WriteLine("The number is odd");
      //  }

        double a = double.Parse(Console.ReadLine());
        bool isEven = a % 2 == 0;
        Console.WriteLine(isEven);
    }
}
