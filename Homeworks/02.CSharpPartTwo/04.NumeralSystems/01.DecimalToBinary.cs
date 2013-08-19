using System;
// Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Deciaml number: ");
        int decNum = int.Parse(Console.ReadLine());

        string binNum = Convert.ToString(decNum, 2); // convert to binary

        Console.WriteLine("Binary representation: {0}", binNum + Environment.NewLine); // print
    }
}