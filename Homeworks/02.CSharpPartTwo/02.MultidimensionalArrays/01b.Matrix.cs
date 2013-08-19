using System;
// Write a program that fills and prints a matrix of size (n, n).

class Matrix // b)
{
    static void Main()
    {
        // get the array size
        Console.Write("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int counter = 1;

        // put numbers in the array
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        // printing
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}