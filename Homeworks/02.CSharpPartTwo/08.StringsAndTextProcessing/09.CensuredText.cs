using System;
using System.Text.RegularExpressions;
// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.
//      Example:
// Microsoft announced its next generation PHP compiler today.
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// Words: "PHP, CLR, Microsoft"
//		The expected result:
// ********* announced its next generation *** compiler today.
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

class CensuredText
{
    static void Main()
    {
        string input = @"Microsoft announced its next generation PHP compiler today.
It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        var censuredWords = "Microsoft, PHP, CLR".Split(new[] {',', '.', ' '}, StringSplitOptions.RemoveEmptyEntries);

        string regex = @"\b(" + String.Join("|", censuredWords) + @")\b";

        Console.WriteLine(Regex.Replace(input, regex, m => new String('*', m.Length)));
    }
}