// A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class Program
{
    static void Main()
    {
        // Get all the information about the company
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        int companyPhone = int.Parse(Console.ReadLine());
        Console.Write("Enter company fax number: ");
        long companyFax = long.Parse(Console.ReadLine());
        Console.Write("Enter company website: ");
        string companySite = Console.ReadLine();

        Console.WriteLine("------------------------------");

        // Get all the information about the manager
        Console.WriteLine("The manager's info.");
        Console.Write("Enter manager's name: ");
        string managerName = Console.ReadLine();
        Console.Write("Enter manager's surname: ");
        string managerSurname = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("_______________________________");

        // Print company and manager's information on the console
        Console.WriteLine("Company info:");
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhone);
        Console.WriteLine("Company fax number: {0}", companyFax);
        Console.WriteLine("Company website: {0}", companySite + Environment.NewLine);

        Console.WriteLine("Manager's info:");
        Console.WriteLine("Manager's name: {0}", managerName);
        Console.WriteLine("Manager's surname: {0}", managerSurname);
        Console.WriteLine("Manager's last name: {0}", managerLastName);
    }
}