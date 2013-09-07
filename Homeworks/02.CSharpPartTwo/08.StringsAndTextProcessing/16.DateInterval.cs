using System;
// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
// Example:
//      Enter the first date: 27.02.2006
//      Enter the second date: 3.03.2006
//      Distance: 4 days

class DateInterval
{
    static void Main()
    {
        Console.Write("Enter the first date [dd.mm.yyyy]: ");
        var firstDateInput = Console.ReadLine().Split(new[] { ' ', '.' });
        Console.Write("Enter the second date [dd.mm.yyyy]: ");
        var secondDateInput = Console.ReadLine().Split(new[] { ' ', '.' });

        DateTime firstDate = new DateTime(Convert.ToInt32(firstDateInput[2]), Convert.ToInt32(firstDateInput[1]),
                                          Convert.ToInt32(firstDateInput[0]));

        DateTime secondDate = new DateTime(Convert.ToInt32(secondDateInput[2]), Convert.ToInt32(secondDateInput[1]),
                                          Convert.ToInt32(secondDateInput[0]));

        TimeSpan firstDateInterval = firstDate - secondDate;
        TimeSpan secondDateInterval = secondDate - firstDate;

        if (firstDateInterval.TotalDays > 0)
        {
            Console.WriteLine("Distance: {0}", firstDateInterval.TotalDays);
        }
        else
        {
            Console.WriteLine("Distance: {0}", secondDateInterval.TotalDays);
        }
    }
}