// 1. Write a program that allocates array of 20 integers and initializes each element
//    by its index multiplied by 5. Print the obtained array on the console.

using System;

class ArrayIndex
{
    static void Main()
    {
        // Initialize an array with 20 elements
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            // Multiply each element by 5
            array[i] = i * 5;

            // Print the array
            Console.WriteLine(array[i]);
        }
    }
}