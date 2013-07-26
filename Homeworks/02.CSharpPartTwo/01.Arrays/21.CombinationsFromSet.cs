// 21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class CombinationsFromSet
{
    static void Main()
    {
        // get size of the array and K elements
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // help variables
        string subset = "";
        int maxSubset = (int)Math.Pow(2, n);
        int count = 0;

        // read the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Index {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // main magic
        for (int i = 0; i < maxSubset; i++)
        {
            subset = "";
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    subset = subset + " " + array[j];
                    count++;
                }
            }

            // printing
            if (count == k)
            {
                Console.WriteLine(subset);
            }
            count = 0;
        }
    }
}