using System;
// Write a program that reads a date and time given in the format:
// day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format)
// along with the day of week in Bulgarian.

class ExactDateAndTime
{
    static void Main()
    {
        Console.Write("Enter a date in a format [dd.mm.yyy hh:mm:ss]: ");
        var input = Console.ReadLine().Split(new[] {' ', '.', ':'});

        DateTime date = new DateTime(Convert.ToInt32(input[2]), Convert.ToInt32(input[1]), Convert.ToInt32(input[0]),
                                     Convert.ToInt32(input[3]), Convert.ToInt32(input[4]), Convert.ToInt32(input[5]));

        Console.WriteLine(date.AddHours(6.5));
    }
}