// 8. Write a program that finds the sequence of maximal sum in given array. Example:
//	  {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//	  Can you do it with only one loop (with single scan through the elements of the array)? -> Yes!

using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        // get the array size
        Console.Write("Enter wanted array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // help variables
        int currentSum = 0;
        int maxSum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;

        // main magic
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            currentSum += array[i];

            if (array[i] > currentSum)
            {
                currentSum = array[i];
                startIndex = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
            }
        }
        Console.WriteLine();

        // printing
        Console.Write("{");
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine("}");
        Console.WriteLine("Maximal sum / number is: {0}", maxSum);
    }
}