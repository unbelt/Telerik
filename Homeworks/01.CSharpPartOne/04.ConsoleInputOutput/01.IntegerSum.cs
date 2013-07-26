// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Program
{
    static void Main()
    {
        // Get the numbers
        Console.Write("Enter the first number: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numberThree = int.Parse(Console.ReadLine());

        // Collect the numbers
        int numberSum = numberOne + numberTwo + numberThree;

        // Print the result on the console
        Console.WriteLine("The sum of the three numbers is: {0}", numberSum);
    }
}