using System;



class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Insert number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Insert number c: ");
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double D = (b * b) - (4 * a * c);
        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2*a);
            Console.WriteLine("Root 1:{0}", x1);
            x2 = (-b - Math.Sqrt(D)) / (2*a);
            Console.WriteLine("Root 2: {0}", x2);
        }
        else if (D == 0)
        {
            double x;
            x1 = x2 = x = -b / (2 * a);
            Console.WriteLine("There is one root: {0}", x);
        }
        else 
        {
            Console.WriteLine("No real roots");
        }

    }
}

