using System;
// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

class BinSearchArray
{
    static void Main()
    {
        // get the array size and K number
        Console.Write("Enter the array size: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        var array = new int[n];

        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            //array[i] = int.Parse(Console.ReadLine());
            array[i] = random.Next(1, 100); // put random numbers in the array
        }
        Console.WriteLine();

        // print the unsorted array
        Console.Write("Unsorted: ");
        foreach (var number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();

        Array.Sort(array); // sort the array

        // print the sorted array
        Console.Write("Sorted: ");
        foreach (var number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
        Console.WriteLine();

        int wantedIndex = Array.BinarySearch(array, k);

        // main magic
        if (k < array[0]) // if K is smaller than smallest number in the array
        {
            Console.WriteLine("The number is not in the array!");
        }
        else
        {
            if (wantedIndex >= 0)
            {
                // if K is in the array
                Console.WriteLine("The number is: {0}", array[wantedIndex]); // print number == K
            }
            else
            {   // if K is NOT in the array
                Console.WriteLine("The number is: {0}", array[~wantedIndex - 1]); // print first number before K
            }
        }
        Console.WriteLine();
    }
}