using System;
// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMaxMethod
{
    static void Main()
    {
        // get 3 integers
        Console.WriteLine("Enter 3 integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maxAB = GetMax(a, b);
        Console.WriteLine();

        // comparing bigger number from "a" and "b" with "c"
        if (c > maxAB)
        {
            Console.WriteLine("Biggest number is {0}", c);
        }
        else
        {
            Console.WriteLine("Biggest number is {0}", maxAB);
        }

    }

    // get bigger from "a" and "b"
    static int GetMax(int a, int b)
    {
        int max = a;
        if (b > a)
        {
            max = b;
        }
        return max;
    }
}