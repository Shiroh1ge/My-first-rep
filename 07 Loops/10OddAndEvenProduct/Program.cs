using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given n integers(given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements.Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            string numbersStr = Console.ReadLine();
            string[] strNumbersArr = numbersStr.Split(new char[' ']);

            for (int j = 0; j < strNumbersArr.Length; j++)
            {
                int[] = new int[strNumbersArr.Length];
                int numbersArr[j] = int.Parse(strNumbersArr[i]);
            }
        }
        
    }
}

