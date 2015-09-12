using System;
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. Examples:


class NumberComparer
{
    static void Main()

    {
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} is greater than {1}",Math.Max(a,b), Math.Min(a, b));
        
    }
}

