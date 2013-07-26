// Write a program that reads an integer number n from the console and prints all the numbers in the interval
// [1..n], each on a single line.

using System;

class Program
{
    static void Main()
    {
        // Read the inputted number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Making loop for comparison
        for (int i = 1; i <= number; i++)
        {
            // Print all the number before inputted number
            Console.WriteLine(i);
        }
    }
}
