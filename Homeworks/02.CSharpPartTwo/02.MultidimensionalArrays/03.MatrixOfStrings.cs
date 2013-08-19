using System;
using System.Linq;
// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

class MatrixOfStrings
{
    static void Main()
    {
        string[,] matrix = new string[,] {
        
        { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" }
        
        };

        int currentSeq = 1;
        int maxSeq = 1;
        string maxElement = "element";
        int direction = 0;

        // check all horizontal seqences going from left to right
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 1;
                }
            }
            currentSeq = 1;
        }

        // check all vertical sequenes going top down
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 2;
                }
            }
            currentSeq = 1;
        }

        // check all diagonals going from top left to down right
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 3;
                    }
                }
                currentSeq = 1;
            }
        }

        // check all diagonals going from top right to down left
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 4;
                    }
                }
                currentSeq = 1;
            }
        }

        // printing
        switch (direction)
        {
            case 1:
                Console.WriteLine("{0} -> {1} times", maxElement, maxSeq);
                break;
            case 2:
                Console.WriteLine("{0} -> {1} times", maxElement, maxSeq);
                break;
            case 3:
                Console.WriteLine("{0} -> {1} times", maxElement, maxSeq);
                break;
            case 4:
                Console.WriteLine("{0} -> {1} times", maxElement, maxSeq);
                break;
            default:
                Console.WriteLine("No repetitions of elements.");
                break;
        }
    }
}