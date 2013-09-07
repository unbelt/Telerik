using System;
// Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

class FillTheString
{
    static void Main()
    {
        Console.WriteLine("Enter a text [< 20 characters]:");
        string input = Console.ReadLine();

        Filler(input);
    }

    private static void Filler(string input)
    {
        if (input.Length > 20)
        {
            Console.WriteLine("Too mutch symbols!");
            Main();
        }
        else
        {
            Console.Write(input);
            for (int i = input.Length; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}