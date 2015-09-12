using System;



class Program
{
    static void Main()
    {
        Console.Write("Insert number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Insert number c: ");
        float c = float.Parse(Console.ReadLine());
    
        Console.WriteLine("Result: |{0,-10:X}|{0,-10:00.000}|{1,10:F2}|{2,10:F3}| ", a, Convert.ToString(a, 2).PadLeft(10, '0'),b,c);
    }
}

