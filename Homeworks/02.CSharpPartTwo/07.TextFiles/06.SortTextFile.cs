using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
// Write a program that reads a text file containing a list of strings,
// sorts them and saves them to another text file.
//  Example:
//	Ivan			George
//	Peter	--->	Ivan
//	Maria			Maria
//	George			Peter

class SortTextFile
{
    static void Main()
    {
        var sortedNames = "SortedNames.txt";

        var names = File.ReadAllLines("names.txt");

        Array.Sort(names);

        File.WriteAllLines(sortedNames, names);

        Console.Write("[DONE] \r\nOpen sorted file? [Y/N]: ");
        OpenFile(sortedNames);
    }

    static void OpenFile(string names)
    {
        string readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(names);
                break;
            default: return;
        }
    }
}