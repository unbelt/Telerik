// Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

// Include all values of the number
enum Numbers
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
}

class DigitName
{
    static void Main()
    {
        // Get a number
        Console.Write("Enter a number [0..9]: ");
        string input = Console.ReadLine();

        // Check is the number is one symbol
        if (input.Length != 1)
        {
            Console.WriteLine("Please, enter a number between 0 and 9!");
            return;
        }
        char number = char.Parse(input);
        int digit = number - '0';
        Numbers asEnum = (Numbers)digit;

        // Comparing inputted number to the cases below
        switch (asEnum)
        {
            case Numbers.Zero:
                Console.WriteLine(Numbers.Zero);
                break;
            case Numbers.One:
                Console.WriteLine(Numbers.One);
                break;
            case Numbers.Two:
                Console.WriteLine(Numbers.Two);
                break;
            case Numbers.Three:
                Console.WriteLine(Numbers.Three);
                break;
            case Numbers.Four:
                Console.WriteLine(Numbers.Four);
                break;
            case Numbers.Five:
                Console.WriteLine(Numbers.Five);
                break;
            case Numbers.Six:
                Console.WriteLine(Numbers.Six);
                break;
            case Numbers.Seven:
                Console.WriteLine(Numbers.Seven);
                break;
            case Numbers.Eight:
                Console.WriteLine(Numbers.Eight);
                break;
            case Numbers.Nine:
                Console.WriteLine(Numbers.Nine);
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}