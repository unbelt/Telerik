// Write a boolean expression that checks for given integer if it can be divided (without remainder)
// by 7 and 5 in the same time.

using System;

class CanBeDivided
{
    static void Main()
    {
        // Declaring needed variables
        int number;
        bool isValid;

        // Making validation
        do
        {
            Console.WriteLine("Please enter a number between 2147483647 and -2147483647:");
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while (number < 2147483647 && number > -2147483647 && isValid == false);

        // If the number can be devided by 5 and 7 without remainder..
        if (number % 5 == 0 && number % 7 == 0)
        {
            // ..print on the console
            Console.WriteLine(isValid == true);
            Console.WriteLine("The number can be devided by 5 and 7 at the same time.");
        }

        // If the number can NOT be devided by 5 and 7 without remainder..
        else
        {
            // ..print on the console
            Console.WriteLine(isValid == false);
            Console.WriteLine("The number CAN'T be devided by 5 and 7 at the same time!");
            
        }
    }
}