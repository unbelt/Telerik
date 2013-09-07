using System;
using System.Text;
// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings. Sample input:
//      Hi!
// Expected output:
//      \u0048\u0069\u0021

class ConvertToUnicode
{
    static void Main()
    {
        Console.WriteLine("Enter text to convert:");
        string input = Console.ReadLine();

        Console.Write("Output: ");
        Console.WriteLine(ConvertToUnicodeLiterals(input));
    }

    private static string ConvertToUnicodeLiterals(string input)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            builder.AppendFormat("\\u{0:X4}", (int)input[i]);
        }

        return builder.ToString();
    }
}