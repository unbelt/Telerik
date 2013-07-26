// We are given integer number n, value v (v=0 or 1) and a position p.
// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1 --> 13 (00001101)
// n = 5 (00000101), p=2, v=0 --> 1 (00000001)

using System;

class SequenceOfOperators
{
    static void Main()
    {
        // Declaring needed variables
        int number;
        int value;
        int position;

        // Get the number
        Console.Write("Enter the number: ");
        number = int.Parse(Console.ReadLine());

        // Get the value
        Console.Write("Enter the value (1 or 0): ");
        value = int.Parse(Console.ReadLine());

        // Get the position
        Console.Write("Enter the position: ");
        position = int.Parse(Console.ReadLine());

        // If the value is zero..
        if (value == 0)
        {
            int mask = ~(position << 1);
            int result = number & mask;
            Console.WriteLine(result);
        }
        
        // If the value is one..
        else if (value == 1)
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(@"Try to enter 1 or 0 at the ""value"".");
        }
    }
}