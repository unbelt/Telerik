using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area
// of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.
// Example:
// 4
// 2 3 3 4
// 0 2 3 4	--->  17
// 3 7 1 2
// 4 3 3 2

class MaximalSumArea
{
    static void Main()
    {
        Console.Write("Ener the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        var matrix = new int[n, n];

        const string outputPath = "output.txt";

        string[] input = File.ReadAllLines("numbers.txt");

        for (int i = 0; i < input.Length; i++)
        {
            string[] currentLine = input[i].Split();
            for (int j = 0; j < currentLine.Length; j++)
            {
                matrix[i, j] = int.Parse(currentLine[j]);
            }
        }

        int sum = 0;
        int maxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        File.WriteAllText("output.txt", maxSum.ToString());
        Console.Write("[DONE] Open file? [Y/N]: ");
        OpenFile(outputPath);
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