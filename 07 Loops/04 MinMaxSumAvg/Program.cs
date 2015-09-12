using System;
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point). The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.The output is like in the examples below.Examples:
//3    min = 1
//2     max = 5
//5    sum = 8
//1    avg = 2.67


class Program
{
    static void Main()
    {
        Console.Write("Enter number quantity: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive number greater than 0");
            return;        
        }
        double maxNum = double.MaxValue;
        double minNum = double.MinValue;
        double sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
           double number = double.Parse(Console.ReadLine());
            sum += number;

            if (maxNum > number)
            {
                maxNum = number;
            }
            if (minNum < number)
            {
                minNum = number;
            }

        }

        double average = sum / n;

        Console.WriteLine("sum: {0}", sum);
        Console.WriteLine("average: {0:F2}", average);
        Console.WriteLine("max: {0}", maxNum);
        Console.WriteLine("min: {0}", minNum);
    }
}

