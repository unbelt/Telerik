using System;
// Write a program to convert binary numbers to their decimal representation.

class BinaryToDeciamal
{
    static void Main()
    {
        Console.Write("Binary number: ");
        string binNum = Console.ReadLine();

        int decNum = 0;

        // convert to decimal
        for (int i = 0; i < binNum.Length; i++)
        {
            if (binNum[binNum.Length - i - 1] == '0')
            {
                continue;
            }
            decNum += (int)(Math.Pow(2, i));
        }

        Console.WriteLine("Decimal representation: {0}", decNum + Environment.NewLine); // print
    }
}