using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Input number of names: ");
        int n = int.Parse(Console.ReadLine());
        string[] names = new string[n];
        for (int i = 0; i < names.Length; i++)
        {
           names[i] = Console.ReadLine();

        }
        Console.Write("Names: ");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

