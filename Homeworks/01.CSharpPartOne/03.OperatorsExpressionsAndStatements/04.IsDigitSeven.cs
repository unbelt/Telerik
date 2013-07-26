// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 --> true.

using System;

class IsDigitSeven
{
    static void Main()
    {
        //Declaring needed variables
        int number;
        int numberToCheck;
        int isNumberSeven;
        bool isValid;

        // Making validation
        do
        {
            Console.WriteLine("Please enter a number between 2147483647 and -2147483647: ");
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while (number < 2147483647 | number > 100 && isValid == false);

        // Making calculation to isolate the third digit of the number
        numberToCheck = number / 100;
        isNumberSeven = numberToCheck % 10;

        // If the number is 7..
        if (isNumberSeven == 7)
        {
            // ..print on the console
            Console.WriteLine("Bingo! The third digit of the number {0} is 7!", number);
        }

        // If the number is NOT 7..
        else
        {
            // ..print on the console
            Console.WriteLine("Too bad. The third digit of the number {0} is NOT 7, it's {1}!", number, isNumberSeven);
        }
    }
}