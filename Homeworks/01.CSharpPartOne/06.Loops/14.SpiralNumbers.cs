// * Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class SpiralNumbers
{
    static void Main()
    {
        bool isValid;
        int n = 0;

        do // Get the size of the spiral and validate the input
        {
            Console.Write("Enter the size of the spiral [N > 20]: ");
            isValid = int.TryParse(Console.ReadLine(), out n);
        } while (n >= 20 && isValid == true);
        
        // Array for the spiral
        int[,] spiral = new int[n, n];

        // String for changing the directions
        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        // Main loop
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            spiral[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        // Loop for printing
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Styling
                if (spiral[i, j] < 10)
                {
                    Console.Write("".PadRight(3) + spiral[i, j]);
                }
                else if(spiral[i, j] >= 10 && spiral[i, j] < 100)
                {
                    Console.Write("".PadRight(2) + spiral[i, j]);
                }
                else
                {
                    Console.Write("".PadRight(1) + spiral[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}