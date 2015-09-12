using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h. 

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter length a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter length b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine(area);
    }
}

