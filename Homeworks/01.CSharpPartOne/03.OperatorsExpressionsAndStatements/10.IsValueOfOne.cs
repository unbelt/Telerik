// Write a boolean expression that returns if the bit at position p (counting from 0)
// in a given integer number v has value of 1.
// Example: v=5; p=1 --> false.

using System;

class IsValueOfOne
{
    static void Main()
    {
        // Declaring needed variables
        int number;
        int position;
        int mask;
        int result;
        bool isValid;

        // Making validation
        do
        {
            Console.Write("Enter a number: ");
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while (number < 2147483647 | number > 0 && isValid == false);
        do
        {
            Console.Write("Enter the position: ");
            isValid = int.TryParse(Console.ReadLine(), out position);
        }
        while (position < 99 | position > 0 && isValid == false);

        // Taking the number accordingly the position
        mask = 1 << position;
        result = mask & number;
        result = result >> position;

        // If the number is one..
        if (result == 1)
        {
            // ..print on the console
            Console.WriteLine(result);
            Console.WriteLine(true);
        }

        // If the number is zero..
        else if (result == 0)
        {
            // ..print on the console
            Console.WriteLine(result);
            Console.WriteLine(false);
        }
    }
}