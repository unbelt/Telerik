// 11. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        // read array size and number to check
        Console.Write("Enter wanted array size: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number to check his index: ");
        int wantedNumber = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        // binary search magic goes here
        int index = Array.BinarySearch(array, wantedNumber);
        if (index == -1)
        {
            Console.WriteLine("Index not found!");
        }
        else
        {
            // printing
            Console.WriteLine("The index of number {0} is: {1} ", wantedNumber, index); 
        }


        /********************************************
         * Main logic behind binary search algorithm*
         * ******************************************
        
        int min = 0; // starting point
        int max = array.Length - 1; // ending point
        int index = 0;

        while (min <= max)
        {
            int mid = (min + max) / 2; // find middle point
            int currMid = array[mid]; // current middle point

            if (currMid == wantedNumber) // if wanted element is in the current middle point
            {
                index = mid; // wanted element is here
                break;
            }
            else if (currMid < wantedNumber) // if wanted element is greater than current middle point
            {
                min = mid + 1; // we search in the right of middle point
            }
            else
            {
                max = mid - 1; // we search in the left of middle point
            }
        }
        */
    }
}