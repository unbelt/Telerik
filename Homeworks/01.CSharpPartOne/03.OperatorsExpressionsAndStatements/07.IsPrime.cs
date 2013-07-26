// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsPrime
{
    static void Main()
    {
        //Declaring needed variables
        int number = 13;
        int zero = 0;
        bool isValid;

        // Making validation
        do
        {
            Console.WriteLine("Enter a number between 2147483647 and -2147483647: ");
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while (number < 2147483647 | number > -2147483647 && isValid == false);

        // Making a cycle to check is the number is prime
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                zero++;
            }
        }
        if (zero == 2)
        {
            Console.WriteLine("The number {0} is prime!", number);
        }
        else
        {
            Console.WriteLine("The number {0} is NOT prime!", number);
        }
    }
}