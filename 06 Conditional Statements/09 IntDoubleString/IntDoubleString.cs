using System;
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end.Print the result at the console. Use switch statement.Example:


class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
       

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int choiceOne = int.Parse(Console.ReadLine());
                Console.WriteLine(choiceOne + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double choiceTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(choiceTwo + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string choiceThree = Console.ReadLine();
                Console.WriteLine(choiceThree + "*");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

