// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        // We get one number
        Console.Write("Show me all numbers (not divisible by 3 and 7) to number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            // We skip numbers that can be divided by 3 and 7 here and print the rest
            if (!(i % 3 == 0) && !(i % 7 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}