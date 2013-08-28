using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Linq;
// Write a program that reads a list of words from a file words.txt
// and finds how many times each of the words is contained in another file test.txt.
// The result should be written in the file result.txt
// and the words should be sorted by the number of their occurrences in descending order.
// Handle all possible exceptions in your methods.

class CountListedWords
{
    static void Main()
    {
        string resultPath = "result.txt";
        string[] listedWords = File.ReadAllLines("words.txt");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("test.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < listedWords.Length; i++)
                {
                    string regex = @"\b" + listedWords[i] + @"\b";
                    MatchCollection matches = Regex.Matches(line, regex, RegexOptions.IgnoreCase);
                    if (dictionary.ContainsKey(listedWords[i]))
                    {
                        dictionary[listedWords[i]] += matches.Count;
                    }
                    else
                    {
                        dictionary.Add(listedWords[i], matches.Count);
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter("result.txt"))
        {
            foreach (var wordCount in dictionary.OrderByDescending(key => key.Value))
            {
                writer.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
            }
        }

        Console.Write("[DONE] \r\nOpen file? [Y/N]: ");
        OpenFile(resultPath);
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