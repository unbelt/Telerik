using System;
// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

class SumAndProductOfGivenSet
{
    static void Main()
    {
        Console.WriteLine("Min of 3, -5, 12, 305: {0}", Min(3, -5, 12, 305));
        Console.WriteLine("Max of 3, -5, 12, 305: {0}", Max(3, -5, 12, 305));
        Console.WriteLine("Average of 3, -5, 12, 305: {0}", Average(3, -5, 12, 305));
        Console.WriteLine("Sum 3, -5, 12, 305: {0}", Sum(3, -5, 12, 305));
        Console.WriteLine("Product of 3, -5, 12, 305: {0}", Product(3, -5, 12, 305));

        Console.WriteLine();
    }

    static int Product(params int[] sequence)
    {
        int product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static int Sum(params int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static double Average(params int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    static int Max(params int[] sequence)
    {
        int bestMax = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > bestMax)
            {
                bestMax = sequence[i];
            }
        }
        return bestMax;
    }

    static int Min(params int[] sequence)
    {
        int bestMin = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < bestMin)
            {
                bestMin = sequence[i];
            }
        }
        return bestMin;
    }
}