// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class Program
{
    static void Main()
    {
        // Get the first number
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        // Get the second number
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        // Making calculation by getting absolute value of the number
        Console.WriteLine("Greater number: {0}", (a + b + Math.Abs(a - b)) / 2);
        Console.WriteLine("Smaller number: {0}", (a + b - Math.Abs(a - b)) / 2);
    }
}
