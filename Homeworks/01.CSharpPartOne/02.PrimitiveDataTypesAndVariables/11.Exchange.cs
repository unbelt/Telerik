// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class Exchange
{
    static void Main()
    {
        /* Get the first number */
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        /* Get the second number */
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        /* Makes a third variable with value of "number1" */
        int number = number1;

        /* Here goes the magic */
        number1 = number2;
        number2 = number;

        /* Print the exchanged numbers */
        Console.WriteLine("{0} <---> {1}", number1, number + Environment.NewLine);
    }
}