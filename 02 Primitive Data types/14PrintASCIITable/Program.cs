using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i<= 255; i++)
        {
          
          Console.Write(Char.ConvertFromUtf32(i) + " ");
        }
    }
}

