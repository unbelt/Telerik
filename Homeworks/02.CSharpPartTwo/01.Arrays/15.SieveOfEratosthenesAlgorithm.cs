// 15. Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        // all numbers to check
        bool[] isPrime = new bool[10000000];

        // main magic
        for (int i = 2; i < Math.Sqrt(isPrime.Length); i++)
        {
            if (isPrime[i] == false)
            {
                for (int j = i * i; j < isPrime.Length; j = j + i)
                {
                    isPrime[j] = true;
                }
            }
        }

        // printing
        for (int i = 2; i < isPrime.Length; i++)
        {
            if (isPrime[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}