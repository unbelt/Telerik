using System;
using System.Text;
using System.Text.RegularExpressions;
// Write a program that reverses the words in given sentence.
//	    Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".

class ReverseWords
{
    static void Main()
    {
        string textInput = "C# is not C++, not PHP and not Delphi!";

        string wordsRegex = @"[^\s\.!?,;:]+";
        string separatorsRegex = @"[\s\.!?,;:]+";

        MatchCollection words = Regex.Matches(textInput, wordsRegex);
        MatchCollection separators = Regex.Matches(textInput, separatorsRegex);

        StringBuilder finalSentence = new StringBuilder();

        for (int i = 0; i < words.Count; i++)
        {
            finalSentence.Append(words[words.Count - 1 - i]);
            finalSentence.Append(separators[i]);
        }

        Console.WriteLine(finalSentence.ToString());
    }
}