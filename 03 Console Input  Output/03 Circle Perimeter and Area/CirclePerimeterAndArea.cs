using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:


class CirclePerimeterAndArea
{
    static void Main()
    {
        double circleRadius = double.Parse(Console.ReadLine());
        double circleArea = 3.14 * circleRadius * circleRadius;
        double circlePerimeter = 2 * 3.14 * circleRadius;
        Console.WriteLine("Area:{0:F2}", circleArea);
        Console.WriteLine("Perimeter:{0:F2}",circlePerimeter);
        

    }
}

