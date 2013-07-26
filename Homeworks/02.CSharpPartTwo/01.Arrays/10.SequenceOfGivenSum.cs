// 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
//     Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        // get the array size and wanted sum
        Console.Write("Enter wanted array size: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter wanted sum: ");
        int sum = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // help variables
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // main magic
        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            count = 0;

            for (int j = i; j < n; j++)
            {
                currentSum += array[j];
                if (currentSum < sum)
                {
                    count++;
                }
                if (currentSum > sum)
                {
                    currentSum = 0;
                    count = 0;
                }
                if (currentSum == sum)
                {
                    startIndex = j - count; // get the starting point
                    endIndex = j; // get the ending point
                    break;
                }
            }
        }

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
    }
}