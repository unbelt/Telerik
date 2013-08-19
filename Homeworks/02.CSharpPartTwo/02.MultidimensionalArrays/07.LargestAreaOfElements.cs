using System;
// * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.

class LargestAreaOfElements
{
    static void PrintMatrix(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (int cell in matrix) max = Math.Max(max, cell);
        int cellSize = (int)Math.Log10(Math.Max(max, 1)) + 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(Convert.ToString(matrix[i, j]).PadRight(cellSize, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
    }

    static bool IsTraversable(int[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }

    static int currentSum = 0;
    static int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
    static void DFS(int[,] matrix, int row, int col)
    {
        int value = matrix[row, col];
        matrix[row, col] = 0; // mark visited

        currentSum++;

        // check neighbours
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int _row = row + directions[direction, 0];
            int _col = col + directions[direction, 1];

            if (IsTraversable(matrix, _row, _col) && matrix[_row, _col] == value) DFS(matrix, _row, _col);
        }
    }

    static void Main()
    {
        int[,] matrix = { { 1, 3, 2, 2, 2, 4 }, { 3, 3, 3, 2, 4, 4 }, { 4, 3, 1, 2, 3, 3 }, { 4, 3, 1, 3, 3, 1 }, { 4, 3, 3, 3, 1, 1 } };

        int maxSum = 0;

        // for each cell
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0) // if not visited
                {
                    currentSum = 0;
                    DFS(matrix, i, j);

                    maxSum = Math.Max(currentSum, maxSum);

                    PrintMatrix(matrix);
                    Console.WriteLine(currentSum + "\n");
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}