using System;
class Program
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int Holidays = int.Parse(Console.ReadLine());
        int HometownWeekends = int.Parse(Console.ReadLine());
        double totalPlays = 0;
        totalPlays += HometownWeekends;
        totalPlays += (52 - HometownWeekends) * (2 / 3);
        totalPlays += Holidays * 0.5;
    }
}

