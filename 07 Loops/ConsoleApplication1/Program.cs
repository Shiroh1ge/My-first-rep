using System;
//Write a program that finds the factorial of a given number. Print the result on the console

class Program
{
    static void Main()
    {
        Console.Write("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }


        Console.WriteLine("n! = {0}", factorial);


    }
}
//
//using System;

//namespace ConsoleApplication4
//{
//    class Program
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            decimal factorial = 1;
//            while (true)
//            {
//                if (n <= 1)
//                {
//                    break;
//                }
//                factorial *= n;
//                n--;
//            }
//            Console.WriteLine(factorial);
//        }

//    }
//}

