// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinimalAndMaximal
{
    static void Main()
    {
        // Get the number count
        Console.Write("How meny numbers do You like to enter: ");
        int input = int.Parse(Console.ReadLine());

        // useless counter?
        int counter = 1;

        // Make an array as user input
        int[] numberArr = new int[input];
        
        // Loop to get all numbers
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter number {0}: ", counter++);
            numberArr[i] = int.Parse(Console.ReadLine());
        }

        int min = numberArr[0];
        int max = numberArr[0];

        // Loop for finding lowest and largest number in the array
        for (int i = 0; i < numberArr.Length; i++)
        {
            if (max < numberArr[i])
            {
                max = numberArr[i];
            }
            if (min > numberArr[i])
            {
                min = numberArr[i];
            }
        }
        // separator
        Console.WriteLine("-----------------------------");

        // Result
        Console.WriteLine("The lowest number is: {0}", min);
        Console.WriteLine("The largest number is: {0}", max);
       
    }
}