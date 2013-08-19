using System;
using System.Collections.Generic;
// Write a method that reverses the digits of given decimal number.
// Example: 256 -> 652

class ReverseDigits
{
    static void Main()
    {
        // get input
        Console.Write("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        ReversedDigits(number);
    }

    private static void ReversedDigits(decimal number)
    {
        // convert to string to get a lenght
        string digits = number.ToString();
        // reverse all
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}