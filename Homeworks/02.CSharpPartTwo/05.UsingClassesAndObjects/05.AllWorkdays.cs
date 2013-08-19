using System;
// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class AllWorkdays
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter a date [DD/MM/YYYY]: ");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine();

        WorkDaysCounter(endDate);
    }

    private static void WorkDaysCounter(DateTime endDate)
    {
        DateTime startDate = DateTime.Today;

        if (startDate > endDate) // validation
        {
            Console.WriteLine("Wrong input!");
            return;
        }

        int totalDays = (endDate - startDate).Days + 1;

        DateTime[] officialHolydays =
        { 
            // You can add more if you want
            new DateTime(endDate.Year, 1, 1),
            new DateTime(endDate.Year, 8, 7),
            new DateTime(endDate.Year, 12, 24),
            new DateTime(endDate.Year, 12, 25),
            new DateTime(endDate.Year, 12, 26),
        };

        int workdaysCount = 0;

        for (int i = 1; i <= totalDays; i++)
        {
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                bool isHoliday = false;
                foreach (var holiday in officialHolydays)
                {
                    // check for holidays
                    if (startDate.Month == holiday.Month && startDate.Day == holiday.Day)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workdaysCount++;
                }
            }

            startDate = startDate.AddDays(1); // add one day
        }

        Console.WriteLine("Total workdays: {0}", workdaysCount + Environment.NewLine);
    }
}