// Write a program that, for a given two integer numbers N and X, calculates the sum
// S = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class SumOfNX
{
    static void Main()
    {
        // Get N and X
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;

        for (int i = 1; i < n; i++)
        {
            double factorialN = 1;
            for (int j = i; j > 1; j--)
            {
                factorialN *= j;
            }
            sum += factorialN / Math.Pow((double)x, (double)i);
        }
        Console.WriteLine(sum);
    }
}