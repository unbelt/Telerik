// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int num = 0;
        int sum = 0;

        Console.Write("The sum of: 0");

        while (num < n)
        {
            num++;
            sum += num;
            Console.Write(" + " + num);
        }
        Console.WriteLine(" = " + sum);
    }
}