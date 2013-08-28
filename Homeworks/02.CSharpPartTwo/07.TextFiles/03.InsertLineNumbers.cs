using System;
using System.Diagnostics;
using System.IO;
// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

class InsertLineNumbers
{
    static void Main()
    {
        // Files location --> \bin\Debug\
        string filePath = "text.txt";
        string newFilePath = "LinedText.txt";

        LineNumbers(filePath, newFilePath);

        Console.Write("[DONE] \r\nOpen file [Y/N]: ");
        OpenFile(newFilePath);
    }

    private static void LineNumbers(string filePath, string newFilePath)
    {
        using (TextWriter newFile = File.CreateText(newFilePath))
        {
            try
            {
                var text = File.ReadAllLines(filePath);
                for (int i = 0; i < text.Length; i++)
                {
                    newFile.WriteLine("{0}. {1}", i + 1, text[i]);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O exception occurred!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have premission to open the file!");
            }
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