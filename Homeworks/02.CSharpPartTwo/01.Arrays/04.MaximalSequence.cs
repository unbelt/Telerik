// 4. Write a program that finds the maximal sequence of equal elements in an array.
//    Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

class MaximalSequence
{
    static void Main()
    {
        // Make an array and get the size
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        // Help variables
        int len = 1;
        int bestLen = 0;
        int bestStart = 0;

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
                    if (array[j] == array[j + 1])
                    {
                        len++;
                    }
                    else
                    {
                        len = 1; // We make that 1 for current number
                    }

                    // ..if there is a better length
                    if (len >= bestLen)
                    {
                        bestLen = len;
                        bestStart = array[j];
                    }
                }
            }
        }

        // Printing
        Console.Write("{");
        for (int i = 0; i < bestLen; i++)
        {
            if (i == bestLen - 1)
            {
                Console.Write(bestStart);
            }
            else
            {
                Console.Write("{0}, ", bestStart);
            }
        }
        Console.WriteLine("}");
    }
}