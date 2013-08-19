using System;
// Write a program that shows the binary representation of given 16-bit signed integer number
// (the C# type short).

class BinaryRepresentationOfInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        short number = short.Parse(Console.ReadLine());

        string binNum = Convert.ToString((short)number, 2); // convert to binary

        Console.WriteLine("Binary representation: {0}", binNum + Environment.NewLine); // print
    }
}