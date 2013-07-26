// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
// Use a sequence of if statements.

using System;

class SequenceOfStatements
{
    static void Main()
    {
        // Get three numbers
        Console.Write("Enter a number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter another one: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("..and another one: ");
        int numberThree = int.Parse(Console.ReadLine());

        // Comparing..
        if (numberOne > 0)
        {
            if (numberTwo > 0)
            {
                if (numberThree > 0)
                {
                    // 1 * 1 * 1
                    Console.WriteLine("+");
                }
                else
                {
                    // 1 * 1 * -1
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (numberThree > 0)
                {
                    // 1 * -1 * 1
                    Console.WriteLine("-");
                }
                else
                {
                    // 1 * -1 * -1
                    Console.WriteLine("+");
                }
            }
        }
        else
        {
            if (numberTwo > 0)
            {
                if (numberThree > 0)
                {
                    // -1 * 1 * 1
                    Console.WriteLine("-");
                }
                else
                {
                    // -1 * 1 * -1
                    Console.WriteLine("+");
                }
            }
            else
            {
                if (numberThree > 0)
                {
                    // -1 * -1 * 1
                    Console.WriteLine("+");
                }
                else
                {
                    // -1 * -1 * -1
                    Console.WriteLine("-");
                }
            }
        }
    }
}