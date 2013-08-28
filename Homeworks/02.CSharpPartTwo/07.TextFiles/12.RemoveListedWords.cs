using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

class RemoveListedWords
{
    static void Main()
    {
        string path = "text.txt";

        try
        {
            string listedWords = File.ReadAllText("ListedWords.txt"); // Contains: first, test
            string text = File.ReadAllText(path);

            string pattern = @"\b(" + String.Join("|", File.ReadAllLines("ListedWords.txt")) + @")\b";
            File.WriteAllText(path, Regex.Replace(text, pattern, String.Empty, RegexOptions.IgnoreCase));

            Console.Write("[DONE] \r\nOpen the file? [Y/N]: ");
            OpenFile(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("File directory not found!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have premission to access the file.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred!");
        }
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