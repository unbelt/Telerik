// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
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

        // If the number can be devided by 2 without remainder..
        if(number % 2 == 0)
        {
            // ..print on the console
            Console.WriteLine("The number is even!");
        }
        // If the number can NOT be divided by 2 without remainder..
        else
        {
            // ..print on the console
            Console.WriteLine("The number is odd!");
        }
    }
}