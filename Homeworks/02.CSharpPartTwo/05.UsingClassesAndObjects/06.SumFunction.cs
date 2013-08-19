using System;
// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.
// Example: string = "43 68 9 23 318" -> result = 461

class SumFunction
{
    static void Main()
    {
        Console.WriteLine("Enter a numbers [separated with spaces]: ");
        var input = Console.ReadLine();

        string[] numbers = input.Split(' '); // clear spaces

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += int.Parse(numbers[i]);
        }

        Console.WriteLine("Sum = {0}", sum + Environment.NewLine);
    }
}