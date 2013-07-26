// Write a program that safely compares floating-point numbers with precision of 0.000001.
// Examples:(5,3 ; 6,01) --> false;  (5,00000001 ; 5,00000003) --> true

using System;

class ComparingNumbers
{
    static void Main()
    {
        /* Get the first number */
        Console.Write("Enter a number: ");
        double number1 = double.Parse(Console.ReadLine());

        /* Get the second number */
        Console.Write("Enter a number to compire: ");
        double number2 = double.Parse(Console.ReadLine()); 

        /* Compares the two numbers */
        bool isEqual = number1 == number2;

        /* If the numbers are equal.. */
        if (isEqual)
        {
            /* ..print on the console */
            Console.WriteLine("The numbers are equal!");
        }
        /* If the nnubers are not equal.. */
        else
        {
            /* ..print on the console */
            Console.WriteLine("The two numbers are not equal!");
        }

        /* Print on the console (false / true) */
        Console.WriteLine(isEqual + Environment.NewLine);
    }
}