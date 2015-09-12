using System;
//Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.Use a sequence of if operators.Examples:

class Program
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a < 0 )
        {
            if (b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else Console.WriteLine("+");
        }
        else
        {
            if (b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        {

        }
       

    }
}

