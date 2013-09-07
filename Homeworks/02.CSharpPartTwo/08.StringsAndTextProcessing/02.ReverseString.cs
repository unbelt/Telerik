using System;
// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample" -> "elpmas".

class ReverseString
{
    static void Main()
    {
        string text = "sample";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }
}