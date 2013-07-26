// Write a program to print the first 100 members of the sequence of Fibonacci:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        // Declaring needed variables
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal result = 0;

        // Print the start ^_^
        Console.WriteLine(0);

        // The loop for this amazing sequence
        for (int i = 0; i <= 100; i++)
        {
            firstNumber = secondNumber;
            secondNumber = result;
            result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
    }
}