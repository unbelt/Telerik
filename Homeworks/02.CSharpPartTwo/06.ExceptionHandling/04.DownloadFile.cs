using System;
using System.Net;
using System.IO;
using System.Diagnostics;
// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
// and stores it the current directory. Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

class DownloadFile
{
    static void Main()
    {
        using (WebClient web = new WebClient())
        {
            try
            {
                // Download and save the file
                web.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"D:\Logo-BASD.jpg");
            }
            catch (WebException)
            {
                Console.WriteLine("An error occurred while downloading data, or the file does not exist.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }

            Console.Write("[Done] The file is saved in 'D:\\'" + Environment.NewLine +
                              " Open file? [Y/N]: ");

            // open file option
            switch (Console.ReadLine().ToLower())
            {
                case "y": OpenFile(); break; 
                default: return;
            }
        }
    }

    // open file method
    static void OpenFile()
    {
        try
        {
            Process.Start(@"D:\Logo-BASD.jpg");
        }
        catch (ApplicationException)
        {
            Console.WriteLine("Failed loading image!");
        }
    }
}