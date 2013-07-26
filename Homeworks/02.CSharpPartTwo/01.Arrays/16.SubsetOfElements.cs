// 16. * We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
// Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;

class SubsetOfElements
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
        Console.Write("Yes - > (");
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0} + ", array[i]);
            }
        }
        Console.WriteLine(")");
    }
}