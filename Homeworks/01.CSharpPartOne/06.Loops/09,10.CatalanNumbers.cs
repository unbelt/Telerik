// Write a program to calculate the Nth Catalan number by given N.
// Nth Catalan number = (2n)! / (n + 1)! * n! for n >= 0.

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        long n = long.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("The {0} Catalan number is: 1", n);
        }
        if (n > 0)
        {
            BigInteger nFactoriel = 1;
            BigInteger multipliedNFact = 1;
            BigInteger nPlusOneFact = 1;
            for (long i = 1; i <= 2*n; i++)
            {
                if (i <= n)
                {
                    nFactoriel = nFactoriel * i;
                    multipliedNFact = nFactoriel;
                }
                if (i == n + 1)
                {
                    nPlusOneFact = nFactoriel * i;
                    multipliedNFact = nPlusOneFact;
                }
                if (i > n + 1)
                {
                    multipliedNFact = multipliedNFact * i;
                }
            }
            BigInteger denominator = nPlusOneFact * nFactoriel;
            BigInteger result = multipliedNFact / denominator;
            Console.WriteLine("The {0} Catalan number is: {1}", n, result);
        }
    }
}