using System;
//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.Write a program that reads the information about a company and// its manager and prints it back on the console.



class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax Number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite =  Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstname = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = (Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = (Console.ReadLine());

        Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6}(age: {7}, tel. {8}", companyName, companyAdress, phoneNumber, faxNumber, webSite, managerFirstname, managerLastName,managerAge, managerPhone);

    }
}

