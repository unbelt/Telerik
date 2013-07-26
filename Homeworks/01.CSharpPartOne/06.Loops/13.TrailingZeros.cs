// * Write a program that calculates for given N how many trailing zeros present at the end of the number N!.
// Examples:
//	N = 10 -> N! = 3628800 -> 2
//	N = 20 -> N! = 2432902008176640000 -> 4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        // Get a number
        Console.Write("Enter a number to check: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger number = 1;
        BigInteger nFact = 1;
        int counter = 0;

        // Calculate number's factorial
        for (int i = 1; i <= n; i++)
        {
            number = number *= i;
            nFact = number;
        }

        // Loop for checking is there a zero at the end
        while (nFact % 5 == 0)
        {
            counter++;
            nFact /= 10; // Remove the last zero
        }

        // Print..
        Console.WriteLine("N = {0} -> N! = {1} -> {2}", n, number, counter);
    }
}