// 6. Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

class MaximalSumArray
{
    static void Main()
    {
        Console.Write("Enter wanted array size: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of elements to count: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maxSum = int.MinValue;

        // loops for calculating sums of numbers to K
        for (int i = 0; i <= n - k; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
            }
            // store max sum found
            if (sum > maxSum)
            {
                maxSum = sum;
            }
            sum = 0;
        }
        // print the result
        Console.WriteLine("The maximal sum in the array with K elements is: {0}", maxSum);
    }
}