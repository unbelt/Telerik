using System;
using System.Collections.Generic;
// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class ListOfWords
{
    static void Main()
    {
        Console.WriteLine("Enter a list of words: ");
        var wordList = new string[0];
        wordList = (Console.ReadLine().Split(' '));
        Array.Sort(wordList);
        Console.WriteLine();

        Console.WriteLine("Result:");

        foreach (var word in wordList)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine();
    }
}