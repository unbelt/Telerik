using System;
// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

class EqualNumbersCount
{
    static void Main()
    {
        Console.Write("Size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.Write("Enter number to check: ");
        int wantedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        NumberCount(array, wantedNumber);
    }

    private static void NumberCount(int[] array, int wantedNumber)
    {
        int counter = 0;
        Random random = new Random();

        // check for equal numbers
        foreach (var item in array)
        {
            // put random numbers in the array
            array[item] = random.Next(1, 10); // from 0 to 10
            Console.Write("{0} ", array[item]);

            if (wantedNumber == array[item])
            {
                counter++;
            }
        }
        Console.WriteLine();

        // print result
        Console.WriteLine("Number {0} appears {1} time(s) in the array.{2}", wantedNumber, counter, Environment.NewLine);
    }
}