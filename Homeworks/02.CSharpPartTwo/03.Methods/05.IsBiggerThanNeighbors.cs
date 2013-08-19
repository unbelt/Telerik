using System;
// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class IsBiggerThanNeighbors
{
    static void Main()
    {
        Console.Write("Array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n + 2];

        Console.Write("Enter the wanted point: ");
        int wantedPoint = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Random random = new Random();

        // generate random numbers in the array
        for (int i = 1; i <= n; i++)
        {
            array[i] = random.Next(1, 10); // from 1 to 10
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        ComparePoint(n, array, wantedPoint);
    }

    private static void ComparePoint(int n, int[] array, int wantedPoint)
    {
        // main loop
        for (int i = 1; i <= n; i++)
        {
            if (i == n - 1 && wantedPoint <= n && wantedPoint > 0) // validation
            {
                // some styling for utility
                for (int j = 0; j < wantedPoint; j++)
                {
                    if (j < wantedPoint - 1)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.WriteLine("^");
                    }
                }

                // comparing the point with it's two neighbors
                if (array[wantedPoint] <= array[wantedPoint - 1] ||
                array[wantedPoint] <= array[wantedPoint + 1])
                {
                    Console.WriteLine("The point you chose is NOT bigger than it's neighbors.");
                    break;
                }
                else if (array[wantedPoint] > array[wantedPoint - 1] &&
                         array[wantedPoint] > array[wantedPoint + 1])
                {
                    Console.WriteLine("The point you chose is bigger than it's neighbors.");
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}
