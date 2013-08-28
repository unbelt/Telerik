using System;
using System.IO;
using System.Diagnostics;
// Write a program that concatenates two text files into another text file.

class ConcatenatesTextFiles
{
    static void Main()
    {
        // Files location --> \bin\Debug\
        string firstFilePath = @"text1.txt"; 
        string secondFilePath = @"text2.txt";
        string newFilePath = @"text1+2.txt";

        ConcatenateFiles(firstFilePath, secondFilePath, newFilePath);

        Console.Write("[DONE] \r\nOpen file (Y/N): ");
        OpenFile(newFilePath);
    }

    static void ConcatenateFiles(string firstFilePath, string secondFilePath, string newFilePath)
    {
        using (TextWriter newFile = File.CreateText(newFilePath))
        {
            try
            {
                // read the text from the files
                string firstFileText = File.ReadAllText(firstFilePath);
                string secondFileText = File.ReadAllText(secondFilePath);

                // write the text to the new file
                newFile.Write("First text: \r\n" + firstFileText);
                newFile.Write("\r\n\r\nSecond text:\r\n" + secondFileText);
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

    private static void OpenFile(string path)
    {
        var readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(path);
                break;
            default: return;
        }
    }
}