using System;
// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

class MaximalElementInAPortion
{
    static void Main()
    {
        int[] numbers = { 66, 90, 42, 11, 32, 44, 33, 61, 24, 42, 5, 7, 51, 3, 23, 84, 20, 22, 16, 73, 43, 33, 66, 39, 99};

        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = FindMax(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }

        Console.WriteLine("Descending Order: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Ascending Order: ");
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    private static int FindMax(int[] numbers, int startingIndex)
    {
        int currentMax = int.MinValue;
        int currentMaxIndex = startingIndex;
        for (int j = startingIndex; j < numbers.Length; j++)
        {
            if (numbers[j] > currentMax)
            {
                currentMax = numbers[j];
                currentMaxIndex = j;
            }
        }
        return currentMaxIndex;
    }
}