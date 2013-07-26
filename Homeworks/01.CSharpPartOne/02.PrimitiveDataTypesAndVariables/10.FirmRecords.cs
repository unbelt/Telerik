// A marketing firm wants to keep record of its employees. Each record would have the following characteristics –
// first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
// Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class FirmRecords
{
    static void Main()
    {
        /* Get your first name */
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        /* Get your last name */
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        /* Get your last name */
        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());

        /* Get your gender */
        Console.Write("Enter your gender (m / f): ");
        char gender = char.Parse(Console.ReadLine());

        /* Get your ID number */
        Console.Write("Enter your ID number: ");
        int id = int.Parse(Console.ReadLine());

        /* Get your employee number */
        Console.Write("Enter your unique employee number (between 27560000 and 27569999): ");
        uint employeeNumber = uint.Parse(Console.ReadLine());

        /* If the number is not in the specified range.. */
        if (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            /* ..print error message */
            Console.WriteLine("Please enter a number between 27560000 and 27569999!");
        }

        /* Continues to run the program */
        else
        {
            /* Print all the data collected */
            Console.WriteLine
            ("\n First name: {0} \n Last name: {1} \n Age: {2} \n Gender: {3}  \n ID number: {4} \n Unique employee number: {5}",
            firstName, lastName, age, gender, id, employeeNumber + Environment.NewLine);
        }
    }
}