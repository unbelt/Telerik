using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that replaces all occurrences of the substring "start"
// with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

class ReplaceSubstring
{
    static void Main()
    {
        var text = File.ReadAllText("text.txt");
        var replacedText = "ReplacedText.txt";

        string pattern = "start";
        string replace = "finish";

        File.WriteAllText(replacedText, Regex.Replace(text, pattern, replace, RegexOptions.IgnoreCase));

        Console.Write("[DONE] \r\nOpen replaced text? [Y/N]: ");
        OpenFile(replacedText);
    }

    static void OpenFile(string text)
    {
        string readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(text);
                break;
            default: return;
        }
    }
}