using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(date1);
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(date2);
        System.TimeSpan result = date1 - date2;
        Console.WriteLine("{0:dd}", result);

        

    }
}
