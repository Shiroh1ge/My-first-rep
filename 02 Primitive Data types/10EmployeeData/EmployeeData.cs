﻿using System;
/*Problem 10.	Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console. */

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 22;
            string gender = "m";
            long personalID = 66215612562156;
            long uniqueEmployeeNumber = 27569999;
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " +lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + personalID);
            Console.WriteLine("Unique employee number: " + uniqueEmployeeNumber);

        }
    }

