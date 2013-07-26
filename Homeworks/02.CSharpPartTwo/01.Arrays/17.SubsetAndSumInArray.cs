// 17. * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetAndSumInArray
{
    static void Main()
    {
        // Get N, K, S numbers
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        // help variables
        int counter = 0;
        string subset = "";

        for (int i = 0; i < n; i++)
        {
            Console.Write("Index {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSubset = (int)Math.Pow(2, n);

        // main magic
        for (int i = 0; i < n; i++)
        {
            subset = "";
            long checkingSum = 0;
            int lenCounter = 0;

            for (int j = 0; j <= n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    checkingSum = checkingSum + array[j];
                    subset = subset + " " + array[j];
                    lenCounter++;
                }
            }

            // printing
            if (checkingSum == s && lenCounter == k)
            {

                Console.WriteLine("Number of subest that have the sum of: {0}", s);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", s, subset);
            }
        }
        Console.WriteLine(counter);
    }
}