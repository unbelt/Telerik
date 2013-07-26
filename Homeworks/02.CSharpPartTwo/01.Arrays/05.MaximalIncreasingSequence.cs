// 5. Write a program that finds the maximal increasing sequence in an array.
//    Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        // Make an array and get the size
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        // Help variables
        int len = 1;
        int bestLen = 0;
        int startLen = 0;

        // Loop to fill up the array
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            // Check is the array is filled up
            if (i == length - 1)
            {
                // Loop for comparing every number with the next
                for (int j = 0; j < i; j++)
                {
                    if ((array[j] + 1) == (array[j + 1]))
                    {
                        len++;
                    }
                    else
                    {
                        len = 1;
                    }
                    if (len > bestLen)
                    {
                        bestLen = len;
                        startLen = j; // Get the index of the last number
                    }
                }
            }
        }

        // Printing
        Console.Write("{");
        for (int i = startLen - bestLen + 1; i < startLen + 1; i++)
        {
            if (i == startLen)
            {
                Console.Write(array[i + 1]);
            }
            else
            {
                Console.Write("{0}, ", array[i + 1]);
            }
        }
        Console.Write("}");
    }
}