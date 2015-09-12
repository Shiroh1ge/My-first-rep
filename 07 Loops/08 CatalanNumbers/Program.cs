using System;
using System.Numerics;

//Write a program to calculate the nth Catalan number by given n(1 < n< 100). Examples:
//n Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

    class CatalanNumbers
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorialN1 = 1;
        BigInteger factorialN2 = 1;
        BigInteger factorialN3 = 1;
        for (int i = 1; i <= 2*n; i++)
        {
            factorialN1 *= i;
            if (i <= n)
            {
                factorialN2 *= i;
            }
            if (i <= n+1)
            {
                factorialN3 *= i;
            }  
        }
        BigInteger result = (factorialN1/(factorialN3*factorialN2));
        Console.WriteLine(result);
    }
    }

