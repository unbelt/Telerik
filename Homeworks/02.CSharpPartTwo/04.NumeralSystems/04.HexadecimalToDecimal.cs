using System;
// Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Hexadecimal number: ");
        string hexNum = Console.ReadLine();

        int decNum = Convert.ToInt32(hexNum, 16); // convert to decimal

        Console.WriteLine("Decimal representation: {0}", decNum + Environment.NewLine); // print
    }
}