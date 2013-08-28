using System;
using System.Diagnostics;
using System.IO;
// Write a program that compares two text files line by line and prints the number of lines that are the same
// and the number of lines that are different. Assume the files have equal number of lines.

class CompareTextFiles
{
    static void Main()
    {
        // Files location --> \bin\Debug\
        string firstFilePath = @"text1.txt";
        string secondFilePath = @"text2.txt";

        int equalCount = 0;
        int diffCount = 0;

        // read the files
        var firstText = File.ReadAllLines(firstFilePath);
        var secondText = File.ReadAllLines(secondFilePath);

        // to work with different file sizes and prevent overflow
        if (firstText.Length > secondText.Length)
        {
            for (int i = 0; i < secondText.Length; i++)
            {
                if (firstText[i] == secondText[i]) // compare the rows
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
        }
        else
        {
            for (int i = 0; i < firstText.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
        }

        Console.WriteLine("Equal rows: {0}", equalCount);
        Console.WriteLine("Different rows: {0}" + Environment.NewLine, diffCount);
    }
}