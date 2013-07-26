// 7. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSortAlgorithm
{
    static void Main()
    {
        // Get the size of the array
        Console.Write("Array size: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        // Print the original array
        Console.Write("Inputted array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        // helping variables
        int tmp = 0;
        int min = 0;

        for (int i = 0; i < length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            tmp = array[min];
            array[min] = array[i];
            array[i] = tmp;
        }

        // Print sorted array
        Console.Write("Sorted array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}