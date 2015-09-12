using System;
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true



    class DivideBy
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            bool divideBy = a % 5 == 0 && a % 7 == 0;
            Console.WriteLine(divideBy);
        }
    }
