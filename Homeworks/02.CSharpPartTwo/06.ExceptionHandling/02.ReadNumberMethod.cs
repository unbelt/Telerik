using System;
using System.Collections.Generic;
// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumberMethod
{
    static void Main()
    {
        Console.WriteLine("Enter 10 progressive numbers in range [1..100]: ");

        var arr = new int[10];

        int minNUmber = 1;
        int maxNumber = 100;

        int currnetNumber = minNUmber;

        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write("a{0}: ", i);
                currnetNumber = ReadNumber(currnetNumber, maxNumber);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number at position {0} is invalid!", i);
                Console.Write("Try again? Y/N: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "y": Main(); // returns to the begining
                        break;
                    default:
                        return; // end
                }
            }

            arr[i] = currnetNumber;
        }
        Console.WriteLine();
        Console.WriteLine("All numbers: {0}", string.Join(", ", arr) + Environment.NewLine);
    }

    static int ReadNumber(int start = 1, int end = 100)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException("The number is not in range!");
        }
        else
        {
            return number;
        }
    }
}