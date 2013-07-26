// Write an expression that extracts from a given integer i the value of a given bit number b.
// Example: i=5; b=2 --> value=1.

using System;

class ExtractsBitNumber
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

        // Print on the console
        Console.WriteLine("At the position {0} of the binary representation of number {1} is digit: {2}", position, number, result);
    }
}