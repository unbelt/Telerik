using System;
// Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomNumbersInRange
{
    static void Main()
    {
        Random rand = new Random(); // random method

        for (int i = 0; i <= 10; i++)
        {
            // interval is from 1 to 200 including
            Console.WriteLine(rand.Next(100, 201));
        }

        Console.WriteLine();
    }
}