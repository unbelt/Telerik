using System;
/* 3. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
      It should hold error message and a range definition [start … end].
      Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
      by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013]. */

class ExceptionTest
{
    static void Main()
    {
        int numStart = 1;
        int numEnd = 100;

        try
        {
            numStart -= numEnd;
            //numEnd += numStart;

            if (numStart < 0 || numEnd > 100)
            {
                throw new InvalidRangeException<int>(numStart, numEnd);
            }


        }
        catch (InvalidRangeException<int> ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Numer start: {0} \r\nNumber end: {1}", ex.Start, ex.End);
        }

        try
        {
            var dateStart = new DateTime(1980, 01, 01);
            var dateEnd = new DateTime(2014, 12, 31);

            if (dateStart < new DateTime(1980, 01, 01) || dateEnd > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>(dateStart, dateEnd);
            }

        }
        catch (InvalidRangeException<DateTime> ex)
        {
            Console.WriteLine();
            Console.WriteLine(ex.Message);
            Console.WriteLine("Date start: {0} \r\nDate end: {1}", ex.Start, ex.End);
        }
    }
}