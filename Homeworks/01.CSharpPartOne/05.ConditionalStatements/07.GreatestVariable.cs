// Write a program that finds the greatest of given 5 variables.

using System;

class GreatestVariable
{
    static void Main()
    {
        // Get five numbers
        Console.Write("Enter number one: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter number three: ");
        int numberThree = int.Parse(Console.ReadLine());
        Console.Write("Enter number four: ");
        int numberFour = int.Parse(Console.ReadLine());
        Console.Write("Enter number five: ");
        int numberFive = int.Parse(Console.ReadLine());

        // Compare with Math.Max
        var max = Math.Max(numberOne, Math.Max(numberTwo, Math.Max(numberThree, Math.Max(numberFour, numberFive))));

        // Sort all the numbers with array
        var array = new int[] { numberOne, numberTwo, numberThree, numberFour, numberFive };
        Array.Sort(array);

        // Get the last number
        var max2 = array[4];

        // Print the result from Math.Max operation
        Console.WriteLine("(using Math.Max) The greatest number is: {0}", max);

        // Print the result from array
        Console.WriteLine("(using Array) The greatest number is: {0}", max2);
    }
}