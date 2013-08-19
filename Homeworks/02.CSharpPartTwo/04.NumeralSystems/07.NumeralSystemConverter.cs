using System;
using System.Linq;
// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class NumeralSystemConverter
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        var inputNumberAsString = Console.ReadLine();
        Console.Write("Enter the base: ");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("Enter a base to convert: ");
        int toBase = int.Parse(Console.ReadLine());
        Console.WriteLine();

        var inputNumberAsInt = FromString(inputNumberAsString, fromBase);
        var outputNumberAsString = ToString(inputNumberAsInt, toBase);

        Console.WriteLine("The number is: {0}", outputNumberAsString + Environment.NewLine);
    }

    static int FromString(string str, int fromBase)
    {
        int value = 0;
        foreach (var ch in str)
        {
            value *= fromBase;
            value += DigitToInt(ch);
        }

        return value;
    }

    static string ToString(int value, int toBase)
    {
        if (value == 0)
        {
            return "0";
        }

        string output = "";
        while (value > 0)
        {
            // 123 456 => string?
            // 100 000
            // 2*10 000
            // 3*1 000

            int biggestPowerLessOrEqual = (int)Math.Pow(toBase, Math.Floor(Math.Log(value, toBase)));
            int timesPowerInNumber = value / biggestPowerLessOrEqual;
            output += IntToDigit(timesPowerInNumber);
            value -= timesPowerInNumber * biggestPowerLessOrEqual;
        }

        return output;
    }

    static string IntToDigit(int number)
    {
        return number.ToString("X");
    }

    static int DigitToInt(char digit)
    {
        // 0, 1, 2, ... A, B ,C ... 
        // 0, 1, 2, ... 10, 11, 12
        return Convert.ToInt32(digit.ToString(), 16);
    }
}