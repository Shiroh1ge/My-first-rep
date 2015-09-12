using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class NumberMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    int result = i + j;
                    Console.Write("{0} ", result);
                }
                Console.WriteLine();
            }

        }
    }
}
