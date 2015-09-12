using System;
//Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2). Examples:


class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double circleX = 0;
        double circleY = 0;
        double radius = 2;
        
        bool isInsideCircle = Math.Pow((x - circleX), 2) + Math.Pow((y - circleY),2) < radius*radius;
        Console.WriteLine(isInsideCircle);
    }
}

