using System;
// Write a method that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.

class FirstBiggerElement
{
    static void Main()
    {
        Console.Write("Size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine();

        Random random = new Random();

        // random number in the array
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(0, 10);
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        CompareNeighbors(n, array);
    }

    private static void CompareNeighbors(int n, int[] array)
    {
        for (int i = 1; i < n; i++)
        {
            // check the first element
            if (i == 1 && array[i - 1] > array[i])
            {
                Console.WriteLine("^");
                Console.WriteLine("The first elemnet bigger than its neighbors is {0}, with index: 0", array[i - 1]);
                Console.WriteLine();
                return;
            }

            // check everything else
            else if (i >= 1 && i < n - 1 && array[i] > array[i - 1] && array[i] > array[i + 1] ||
                     i == n - 1 && array[i] > array[i - 1])
            {
                // styling :)
                for (int j = 0; j <= i; j++)
                {
                    if (j < i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.WriteLine("^");
                    }
                }
                Console.WriteLine("The first elemnet bigger than its neighbors is {0}, with index: {1}", array[i], i);
                Console.WriteLine();
                return;
            }
            Console.WriteLine(-1);
            Console.WriteLine();
        }
    }
}