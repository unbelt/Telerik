// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort // I use help for this! (Wikipedia)
{
    static void Main()
    {
        // Get the size
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        string[] input = new string[n];

        // Get the input
        for (int i = 0; i < n; i++)
        {
            Console.Write("Index {0}: ", i);
            input[i] = Console.ReadLine();
        }
        Console.WriteLine();

        // Sort the array
        QuickSortAlgorithm(input, 0, input.Length - 1);

        // Print sorted array
        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                Console.WriteLine("{0}", input[i]);
            }
            else
            {
                Console.Write("{0}, ", input[i]);
            }
        }
    }

    // Quick sort algorithm main magic
    public static void QuickSortAlgorithm(IComparable[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                // swap
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            QuickSortAlgorithm(elements, left, j);
        }
        if (i < right)
        {
            QuickSortAlgorithm(elements, i, right);
        }
    }
}