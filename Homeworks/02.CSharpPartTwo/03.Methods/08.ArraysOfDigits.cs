﻿using System;
using System.Linq;
using System.Collections.Generic;
// Write a method that adds two positive integer numbers represented as arrays of digits
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

class ArraysOfDigits
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        byte[] numberOne = Console.ReadLine().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
        Console.Write("Enter the second number: ");
        byte[] numberTwo = Console.ReadLine().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();

        List<byte> newNumber = Sum(numberOne, numberTwo);

        Console.Write("The result is: ");
        for (int i = 0; i < newNumber.Count(); i++)
        {
            Console.Write(newNumber[i]);
        }
        Console.WriteLine();
    }

    static List<byte> Sum(byte[] numberOne, byte[] numberTwo)
    {
        byte[] longerNum;
        byte[] shorterNum;
        if (numberOne.Length > numberTwo.Length)
        {
            longerNum = new byte[numberOne.Length];
            shorterNum = new byte[numberTwo.Length];
            for (int i = 0; i < longerNum.Length; i++)
            {
                longerNum[i] = numberOne[i];
            }
            for (int i = 0; i < shorterNum.Length; i++)
            {
                shorterNum[i] = numberTwo[i];
            }
        }
        else
        {
            longerNum = new byte[numberTwo.Length];
            shorterNum = new byte[numberOne.Length];
            for (int i = 0; i < longerNum.Length; i++)
            {
                longerNum[i] = numberTwo[i];
            }
            for (int i = 0; i < shorterNum.Length; i++)
            {
                shorterNum[i] = numberOne[i];
            }
        }

        byte carry = 0;
        byte sum = 0;

        List<byte> result = new List<byte>();

        for (int i = 0; i < shorterNum.Length; i++)
        {
            sum = (byte)(shorterNum[i] + longerNum[i] + carry);
            if (sum >= 10)
            {
                carry = 1;
                sum %= 10;
                result.Add(sum);
            }
            else
            {
                carry = 0;
                result.Add(sum);
            }
        }

        for (int i = shorterNum.Length; i < longerNum.Length; i++)
        {
            sum = (byte)(longerNum[i] + carry);
            if (sum >= 10)
            {
                carry = 1;
                sum %= 10;
                result.Add(sum);
            }
            else
            {
                carry = 0;
                result.Add(sum);
            }
        }

        if (carry == 1)
        {
            result.Add(1);
        }

        return result;
    }
}