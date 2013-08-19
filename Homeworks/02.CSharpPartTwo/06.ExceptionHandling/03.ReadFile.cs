using System;
using System.IO;
using System.Text;
// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFile
{
    static void Main()
    {
        string path = @"C:\WINDOWS\win.ini";

        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access!");
        }
    }
}