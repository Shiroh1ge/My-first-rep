﻿using System;
//Write a program that finds the biggest of three numbers.Examples:
//a b   c biggest
//5	2	2	5
//-2	-2	1	1
//-2	4	3	4
//0 -2.5	5	5
//-0.1 -0.5 -1.1 -0.1



    class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Biggest number is {0}", a);
            }
            else
            {
                Console.WriteLine("Biggest number is {0}", c);
            }
        }
        else if (b > c)
        {
            Console.WriteLine("The biggest number is {0}", b); 
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
    }
}

