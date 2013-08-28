using System;
using System.IO;
// Write a program that reads a text file and prints on the console its odd lines.

class ReadTextFile
{
    static void Main()
    {
        try
        {
            var text = File.ReadAllLines("text.txt"); // File location --> \bin\Debug\
            for (int i = 0; i < text.Length; i += 2)
            {
                Console.WriteLine(text[i]); // print the odd lines
            }
            Console.WriteLine();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not fount!");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have premission to open the file!");
        }
    }
}