using System;
using System.Text;
// Write a program that reads a string from the console and replaces all series of consecutive
// identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

class ReplaceIdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder builder = new StringBuilder();
        char ch = char.MinValue;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != ch)
            {
                builder.Append(text[i]);
                ch = text[i];
            }
        }

        Console.WriteLine(builder);
    }
}