using System;
/* Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost. */
class FloatOrDouble
{
    static void Main()
    {
        double a = 34.567839023;
        Console.WriteLine(a);
        float b = 12.345f;
        Console.WriteLine(b);
        double c = 8923.1234857;
        Console.WriteLine(c);
        float d = 3456.091f;
        Console.WriteLine(d);
    }
}

