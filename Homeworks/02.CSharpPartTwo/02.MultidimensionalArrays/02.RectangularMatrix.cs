using System;
// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class RectangularMatrix
{
    static void Main()
    {
        // get rows and cols of the array
        Console.Write("Array rows: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Array columns: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] matrix = new int[width, height];

        Random random = new Random();

        // array with random numbers
        for (int w = 0; w < matrix.GetLength(0); w++)
        {
            for (int h = 0; h < matrix.GetLength(1); h++)
            {
                matrix[w, h] = random.Next(1, 100); // random number from 1 to 100
                Console.Write("{0, 4}", matrix[w, h]); // print the numbers
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // get the platform size
        Console.Write("Platform width: ");
        int platformX = int.Parse(Console.ReadLine());
        Console.Write("Platform height: ");
        int platformY = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int maxSum = int.MinValue;

        // calculate maximal sum
        for (int row = 0; row < matrix.GetLength(0) - (platformX - 1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - (platformY - 1); col++)
            {
                int sum = 0;
                for (int i = row; i < row + platformX; i++)
                {
                    for (int j = col; j < col + platformY; j++)
                    {
                        sum += matrix[i, j];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        // print the maxial sum
        Console.WriteLine("Max sum: {0}", maxSum);
    }
}