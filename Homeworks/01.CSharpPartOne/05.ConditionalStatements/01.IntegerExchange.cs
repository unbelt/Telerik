// Write an if statement that examines two integer variables and exchanges their values
// if the first one is greater than the second one.

using System;

class IntegerExchange
{
    static void Main()
    {
        // Get the numbers
        Console.Write("Enter a number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        // If first number is greater than second one..
        if (firstNumber > secondNumber)
        {
            // ..print the exchanged numbers
            Console.WriteLine("First: {0}, Second: {1}", secondNumber, firstNumber);
        }

        // If second number is greater than first one..
        else
        {
            // ..print the numbers in order
            Console.WriteLine("First: {0}, Second: {1}", firstNumber, secondNumber);
        }
    }
}
