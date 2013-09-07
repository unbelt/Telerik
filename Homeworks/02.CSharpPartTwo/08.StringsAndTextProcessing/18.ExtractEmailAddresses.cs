using System;
using System.Text.RegularExpressions;
// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEmailAddresses
{
    static void Main()
    {
        string text = @"My email address is filed@abv.bg, but I use klaxon@abv.bg, because of the spam.
The best way to go is example@gmail.com";

        string regex = @"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}";
        MatchCollection collect = Regex.Matches(text, regex);

        foreach (var email in collect)
        {
            Console.WriteLine(email);
        }
    }
}