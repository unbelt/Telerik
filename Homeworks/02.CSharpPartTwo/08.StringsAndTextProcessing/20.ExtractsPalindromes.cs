using System;
using System.Text.RegularExpressions;
// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractsPalindromes
{
    static void Main()
    {
        string text = @"My favorite group is ABBA. I have an eye for details.";

        string regex = @"\b\w+\b";

        MatchCollection words = Regex.Matches(text, regex);

        foreach (Match word in words)
        {
            if (isPalindrome(word))
            {
                Console.WriteLine(word);
            }
        }
    }

    static bool isPalindrome(Match word)
    {
        string wordString = word.ToString();

        for (int i = 0; i < wordString.Length; i++)
        {
            if (wordString[i] != wordString[wordString.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}