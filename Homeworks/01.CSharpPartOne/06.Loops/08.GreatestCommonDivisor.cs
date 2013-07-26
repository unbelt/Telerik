// Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());

        while (true)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (a % b == 0)
            {
                Console.WriteLine("The greatest common divisor is: {0}", b);
                break;
            }

            int temp2 = b;
            b = a % b;
            a = temp2;
        }
    }
}