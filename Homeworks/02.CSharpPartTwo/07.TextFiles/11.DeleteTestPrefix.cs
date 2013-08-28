using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that deletes from a text file all words that start with the prefix "test".
// Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteTestPrefix
{
    static void Main()
    {
        var path = "text.txt"; // Original text: "Test text, but not testing the text for tests!"
        var text = File.ReadAllText(path);
        
        string pattern = @"\b(test\w*)\b";

        File.WriteAllText(path, Regex.Replace(text, pattern, string.Empty, RegexOptions.IgnoreCase));

        Console.Write("[DONE] \r\nOpen the file? [Y/N]: ");
        OpenFile(path);
    }

    static void OpenFile(string path)
    {
        string readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(path);
                break;
            default: return;
        }
    }
}