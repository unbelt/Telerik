using System;
// Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        string hexNum = decNum.ToString("X"); // convert to hexadecimal

        Console.WriteLine("Hexadecimal representation: {0}", hexNum + Environment.NewLine); // print
    }
}