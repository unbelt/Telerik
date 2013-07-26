// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.
using System;

class MatrixOfNumbers
{
    static void Main()
    {
        // Get the size of the matrix
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        // Loop for rows
        for (int row = 1; row <= n; row++)
        {
            // Loop for columns
            for (int col = row; col <= row + (n - 1); col++)
            {
                // Some styling
                if (col < 10)
                {
                    Console.Write("".PadRight(2) + col);
                }
                else
                {
                    Console.Write("".PadRight(1) + col);
                }
            }
            Console.WriteLine();
        }
    }
}