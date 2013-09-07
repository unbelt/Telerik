using System;
// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage
// and in scientific notation. Format the output aligned right in 15 symbols.

class NumberRepresentation
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Hexadecimal: {0,15}", number.ToString("X"));
        Console.WriteLine("Percentage:  {0,15}", number.ToString("P2"));
        Console.WriteLine("Scientific:  {0,15}", number.ToString("G2"));
    }
}