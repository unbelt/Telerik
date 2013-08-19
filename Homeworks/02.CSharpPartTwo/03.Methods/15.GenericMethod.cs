using System;
// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
//   Use generic method (read in Internet about generic methods in C#).

class GenericMethod
{
    static void Main()
    {
        Console.WriteLine("Min of 3, -5, 12, 305: {0}", Min(3, -5, 12, 305));
        Console.WriteLine("Max of 3, -5, 12, 305: {0}", Max(3, -5, 12, 305));
        Console.WriteLine("Average of 3, -5, 1.2, 305: {0}", Average(3, -5, 1.2, 305)); // Requires at least one double number for proper calculation
        Console.WriteLine("Sum 3, -5, 12, 305: {0}", Sum(3, -5, 12, 305));
        Console.WriteLine("Product of 3, -5, 12, 305: {0}", Product(3, -5, 12, 305));

        Console.WriteLine();
    }

    static T Product<T>(params T[] sequence)
    {
        dynamic product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static T Sum<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static T Average<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    static T Max<T>(params T[] sequence)
    {
        dynamic bestMax = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > bestMax)
            {
                bestMax = sequence[i];
            }
        }
        return bestMax;
    }

    static T Min<T>(params T[] sequence)
    {
        dynamic bestMin = int.MaxValue;
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