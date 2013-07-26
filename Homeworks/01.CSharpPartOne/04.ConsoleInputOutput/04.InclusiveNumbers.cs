// Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class Program
{
    static void Main()
    {
        // Get the first number
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        // Get the second number
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        int counter = 0;

        // Making cycle for getting all the numbers between "a" and "b"
        for (int i = a; i <= b; i++)
        {
            // Checking if the numbers can be divided by 5 and initialising the counter
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        // Print the result from the calculation
        Console.WriteLine("p({0},{1}) = {2}", a, b, counter);
    }
}