using System;

    class TheBiggestOf5Numbers
    {
        static void Main()
        {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter number e: ");
        double e = double.Parse(Console.ReadLine());
        if (a > b && a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest number is {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest number is {0}", d);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", e);
        }
    }
}

