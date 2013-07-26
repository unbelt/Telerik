// 18. * Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array.
// Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class IncreasingOrderSort // With a lot of help :(
{
    static bool isSorted(List<int> list)
    {
        bool isSorted = true;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                isSorted = false;
            }
        }

        return isSorted;
    }

    // Printing
    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    // Main magic
    static void Main()
    {
        List<int> arrayOfNumbers = new List<int>() { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        List<int> result = new List<int>();

        int maxi = (int)Math.Pow(2, arrayOfNumbers.Count) - 1;
        int maxElements = 0;

        for (int i = 1; i <= maxi; i++)
        {
            List<int> temporaryList = new List<int>();
            int counter = 0;

            for (int j = 1; j <= arrayOfNumbers.Count; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    temporaryList.Add(arrayOfNumbers[j - 1]);
                    counter++;
                }
            }

            if (counter > maxElements && isSorted(temporaryList))
            {
                result = temporaryList;
                maxElements = counter;
            }

            counter = 0;
        }

        PrintList(result);
    }
}