// 2. Write a program that reads two arrays from the console and compares them element by element.

using System;

class ArrayComparison
{
    static void Main()
    {
        // Get the array size
        Console.Write("Size of the arrays: ");
        int length = int.Parse(Console.ReadLine());

        int[] firstArray = new int[length];
        int[] secondArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            // Read numbers for each array
            Console.Write("firstArray[{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.Write("secondArray[{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // Sort the arrays
        Array.Sort(firstArray);
        Array.Sort(secondArray);
        bool equal = true;

        for (int i = 0; i < length; i++)
        {
            // Check the arrays are equal
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
        }
        Console.WriteLine();

        // Print the result
        if (equal)
        {
            Console.WriteLine("firstArray == secondArray");
        }
        else
        {
            Console.WriteLine("firstArray != secondArray");
        }
    }
}