// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorialMath
{
    static void Main()
    {
        // Get N and K
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K [1 < N < K]: ");
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;
        int sum = 1;
        int factorialSum = k - n;

        // Validation..
        if (n > 1 && n < k)
        {
            // Get factorial for N and K
            do
            {
                factorialN *= n;
                n--;
                factorialK *= k;
                k--;

            } while (n > 0 && k > 0);

            // Get factorial for K - N
            do
            {
                sum *= factorialSum;
                factorialSum--;

            } while (sum > 0);

            BigInteger result = (factorialN * factorialK) / (factorialSum);
            Console.WriteLine("N!*K! / (K-N)! = " + result);

        }
        else if (n < 1)
        {
            Console.WriteLine("N nust be bigger than 1");
        }
        else if (n > k)
        {
            Console.WriteLine("K must be bigger than N;");
        }
    }
}