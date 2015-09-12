using System;
using System.Numerics;
//Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements(also known as the number of combinations) is calculated by the following formula:




class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        for (int j = 1; j <= n - k; j++)
        {
            factorialNK *= j;
        }
        BigInteger result = (factorialN / (factorialK * factorialNK));
        Console.WriteLine(result);

    }
}

