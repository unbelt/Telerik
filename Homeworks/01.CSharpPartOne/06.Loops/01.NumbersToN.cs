// Write a program that prints all the numbers from 1 to N.

using System;

class NumbersToN
{
    static void Main()
    {
        // Get the number
        Console.Write("Show me all numbers to number: ");
        int number = int.Parse(Console.ReadLine());

        // Loop to print all the numbers to the inputted number
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}