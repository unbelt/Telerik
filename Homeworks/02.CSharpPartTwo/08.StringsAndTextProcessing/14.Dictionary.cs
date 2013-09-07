using System;
using System.Collections.Generic;
// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//      .NET – platform for applications from Microsoft
//      CLR – managed execution environment for .NET
//      namespace – hierarchical organization of classes

class Dictionary
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        string input = Console.ReadLine();

        if (dictionary.ContainsKey(input))
        {
            string value = dictionary[input];
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("There is no such word in dictionary!");
        }
    }
}