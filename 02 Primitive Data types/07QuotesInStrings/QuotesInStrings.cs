﻿using System;
/* Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
*/


class Program
{
    static void Main()
    {
        string a = "The \"use\" of quotation causes difficulties";
        Console.WriteLine(a);
        string b = @"The ""use"" of quotation causes difficulties";
        Console.WriteLine(b);
    }
}

