using System;
using System.Globalization;
using System.Text.RegularExpressions;
// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

class ExtractsDates
{
    static void Main()
    {
        string text = "Today is 03.09.2013 and it's Thursday. Tomorrow will be 04.09.2013, Thursday";
        string regex = @"\d{1,2}\.\d{1,2}\.\d{4}";

        MatchCollection dates = Regex.Matches(text, regex);
        var format = new CultureInfo("en-CA", false);

        foreach (Match item in dates)
        {
            DateTime date;
            DateTime.TryParse(item.ToString(), out date);
            Console.WriteLine(date.ToString("dd/MM/yyyy", format));
        }
    }
}