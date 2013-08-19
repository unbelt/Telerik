using System;
// Write a program that prints to the console which day of the week is today. Use System.DateTime

class DayOfTheWeek
{
    static void Main()
    {
        Console.WriteLine("Today is: " + DateTime.Today.DayOfWeek + Environment.NewLine);
    }
}