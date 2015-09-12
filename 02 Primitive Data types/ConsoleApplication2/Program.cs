using System;
/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples: */


class Floats
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (a > b)
        {
            if (a - b > eps)
            {
                Console.WriteLine("a and b are not equal");
            }
            else
            {
                Console.WriteLine("a and b are equal");
            }

        }
        else if (b > a)
        {
            if (b - a > eps)
            {
                Console.WriteLine("a and b are not equal");
            }
            else
            {
                Console.WriteLine("a and b are equal");
            }
        }
        else Console.WriteLine("a and b are equal");
    }
}

