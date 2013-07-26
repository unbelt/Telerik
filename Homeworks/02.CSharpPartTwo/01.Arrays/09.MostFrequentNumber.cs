// 9. Write a program that finds the most frequent number in an array.
//    Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class MostFrequentNumber
{
    static void Main()
    {
        // create an array and get his size
        Console.Write("Enter wanted array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        // help variables
        int numerIndex = 0;
        int currentCount = 1;
        int bestCount = int.MinValue;

        // loop to fill up the array
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array); // helps our counting

        // scan the array for similar numbers
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    numerIndex = array[i];
                }
                currentCount = 1;
            }
        }

        // exeptional case
        if (currentCount > bestCount)
        {
            bestCount = currentCount;
            numerIndex = array[array.Length - 1];
        }

        // print the result
        Console.WriteLine();
        Console.WriteLine("{0} ({1} times)", numerIndex, bestCount);
    }
}