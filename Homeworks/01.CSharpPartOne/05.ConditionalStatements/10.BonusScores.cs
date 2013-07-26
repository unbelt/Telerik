// Write a program that applies bonus scores to given scores in the range [1..9].
// The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
// if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
// If it is zero or if the value is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
    static void Main()
    {
        // Get a number
        Console.Write("Enter a number [1..9]: ");
        string input = Console.ReadLine();

        // Make a validation
        if (input.Length != 1)
        {
            Console.WriteLine("Please, enter a number between 1 and 9!");
            return;
        }
        char number = char.Parse(input);
        int digit = number - '0';

        // Comparing inputted number to the cases below
        switch (digit)
        {
            case 1:
                Console.WriteLine("Output: {0}", digit * 10);
                break;
            case 2:
                Console.WriteLine("Output: {0}", digit * 10);
                break;
            case 3:
                Console.WriteLine("Output: {0}", digit * 10);
                break;
            case 4:
                Console.WriteLine("Output: {0}", digit * 100);
                break;
            case 5:
                Console.WriteLine("Output: {0}", digit * 100);
                break;
            case 6:
                Console.WriteLine("Output: {0}", digit * 100);
                break;
            case 7:
                Console.WriteLine("Output: {0}", digit * 1000);
                break;
            case 8:
                Console.WriteLine("Output: {0}", digit * 1000);
                break;
            case 9:
                Console.WriteLine("Output: {0}", digit * 1000);
                break;
            default:
                Console.WriteLine("Wrong number!");
                break;
        }
    }
}