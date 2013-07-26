// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter unsigned integer: ");
        int number = int.Parse(Console.ReadLine());

        int bitThree = (number & (1 << 3)) >> 3;
        int bitFour = (number & (1 << 4)) >> 4;
        int bitFive = (number & (1 << 5)) >> 5;
        int bitTwentyFour = (number & (1 << 24)) >> 24;
        int bitTwentyFive = (number & (1 << 25)) >> 25;
        int bitTwentySix = (number & (1 << 26)) >> 26;

        int temp;
        int result;

        temp = ((bitThree == 0) ? (temp = number & ~(1 << 24)) : (temp = number | (1 << 24)));
        result = temp;
        temp = ((bitFour == 0) ? (temp = result & ~(1 << 25)) : (temp = result | (1 << 25)));
        result = temp;
        temp = ((bitFive == 0) ? (temp = result & ~(1 << 26)) : (temp = result | (1 << 26)));
        result = temp;
        temp = ((bitTwentyFour == 0) ? (temp = result & ~(1 << 3)) : (temp = result | (1 << 3)));
        result = temp;
        temp = ((bitTwentyFive == 0) ? (temp = result & ~(1 << 4)) : (temp = result | (1 << 4)));
        result = temp;
        temp = ((bitTwentySix == 0) ? (temp = result & ~(1 << 5)) : (temp = result | (1 << 5)));
        result = temp;

        Console.WriteLine("Old binary number:     {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Modifed binary number: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}