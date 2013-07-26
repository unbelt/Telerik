// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class FactorialDev
{
    static void Main()
    {
        bool isValid;
        int n = 0;
        int k = 0;

        // Get valid data
        do
        {
            Console.Write("Enter N: ");
            isValid = int.TryParse(Console.ReadLine(), out n);

            Console.Write("Enter K [1 < K < N]: ");
            isValid = int.TryParse(Console.ReadLine(), out k);

        } while (k < 2 || k >= n || isValid == false);

        // Math?
        int result = 1;
        for (int i = 0; i < (n - k); i++)
        {
            result = result * (n - i);
        }
        Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
    }
}