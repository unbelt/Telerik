using System;
// Write a program that fills and prints a matrix of size (n, n).

class Matrix // a)
{
    static void Main()
    {
        // get the array size
        Console.Write("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int counter = 1;

        // put numbers in the array
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                matrix[col, row] = counter;
                counter++;
            }
        }

        // printing
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}