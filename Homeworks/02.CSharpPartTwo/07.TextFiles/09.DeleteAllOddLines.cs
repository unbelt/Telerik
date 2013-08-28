using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteAllOddLines
{
    static void Main()
    {
        // using temp file
        string tempFile = Path.GetTempFileName();
        var text = "text.txt";

        int lineNumber = 1;

        using (var reader = new StreamReader(text))
        using (var writer = new StreamWriter(tempFile))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (lineNumber % 2 != 0)
                {
                    writer.WriteLine(line);
                }
                lineNumber++;
            }
        }

        File.Delete(text); // delete the old file
        File.Move(tempFile, text); // replace the old file

        Console.Write("[DONE] \r\nOpen the new file? [Y/N]: ");
        OpenFile(text);
    }

    static void OpenFile(string text)
    {
        string readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(text);
                break;
            default: return;
        }
    }
}