using System;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double circleX = 1;
        double circleY = 1;
        double circleRadius = 1.5;
        bool isInsideCircle = Math.Pow((x - circleX), 2) + Math.Pow((y - circleY), 2) <= circleRadius * circleRadius;
        bool isInsideRectangle = x <= 5 && y >= -1 && y <= 1;
        if (isInsideCircle && !isInsideRectangle)

        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

