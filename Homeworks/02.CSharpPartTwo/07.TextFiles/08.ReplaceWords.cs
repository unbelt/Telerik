using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Modify the solution of the previous problem to replace only whole words (not substrings).

class ReplaceWords
{
    static void Main()
    {
        var text = File.ReadAllText("text.txt");
        var replacedText = "ReplacedText.txt";

        string pattern = @"\bstart to finish\b";
        string replace = @"finish to start";

        File.WriteAllText(replacedText, Regex.Replace(text, pattern, replace, RegexOptions.IgnoreCase));

        Console.Write("[DONE] \r\nOpen sorted file? [Y/N]: ");
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