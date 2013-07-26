// 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class VariationsFromSet
{
    // Calculate variations
    private static void Variations(int[] array, int k, int n)
    {
        if (array.Length == k)
        {
            Print(array);
        }
        else
        {
            for (int i = 1; i < n; i++)
            {
                array[k] = i;
                Variations(array, k + 1, n);
            }
        }
    }

    // Print the variations
    private static void Print(int[] array)
    {
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write("{0}", array[i]);
                Console.Write("} ");
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
    }

    // Get N & K
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine();
        int[] var = new int[k];

        Variations(var, 0, n);
        Console.WriteLine();
    }
}