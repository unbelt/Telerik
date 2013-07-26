// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class Program
{
    static void Main()
    {
        // Get a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int numberSum = number;

        // Making loop for adding multiple numbers
        for (int i = 0; i <= number; i++)
        {
            // Get another number
            Console.Write("Add a number: ");
            int numberN = int.Parse(Console.ReadLine());

            // Making variable for collecting the sum of the numbers
            numberSum = (numberSum + numberN);

            // Print on the console the sum of the numbers
            Console.WriteLine("The sum is: " + numberSum);
        }
    }
}