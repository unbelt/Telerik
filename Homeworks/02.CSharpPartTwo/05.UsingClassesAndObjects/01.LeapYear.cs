using System;
// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(DateTime.IsLeapYear(year) + Environment.NewLine);
    }
}