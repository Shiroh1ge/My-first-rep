﻿using System;
//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.Use only one loop.Print the result with 5 digits after the decimal point.
//n x   S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781


namespace _05_CalculateFormula
{
    class calculateFormula
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number x: ");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
               
                result += factorial / Math.Pow(x, i);

            }
            Console.WriteLine(result);
        }
    }
}
