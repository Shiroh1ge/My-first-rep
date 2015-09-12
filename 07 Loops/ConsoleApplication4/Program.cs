using System;
//Write a program that calculates n! / k! for given n and k(1 < k<n< 100). Use only one loop.Examples:
//n k   n! / k!
//5	2	60
//6	5	6
//8	3	6720


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }



        }
        double result = factorialN / factorialK;
        Console.WriteLine(result);
    }

}


