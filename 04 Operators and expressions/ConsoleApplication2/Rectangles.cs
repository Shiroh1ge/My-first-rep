using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter	area
//3	4	14	12
//2.5	3	11	7.5



    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            double area = width * height;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }

