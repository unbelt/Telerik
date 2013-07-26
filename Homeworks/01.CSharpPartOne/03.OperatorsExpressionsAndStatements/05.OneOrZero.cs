// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class OneOrZero
{
    static void Main()
    {
        //Declaring needed variables
        int number;
        string binary;
        ulong binaryNumber;
        ulong isDigitOne;
        bool isValid;

        // Making validation
        do
        {
            Console.WriteLine("Enter a number to check (form 4 to 999999): ");
            isValid = int.TryParse(Console.ReadLine(), out number);
        }
        while(number > 999999 || number < 4 && isValid == false);

        // Converting from decimal to binary 
        binary = (Convert.ToString(number, 2));
        binaryNumber = (Convert.ToUInt64(binary, 2));

        // Move the binary number 2 positions to right
        isDigitOne = binaryNumber >> 2;

        // If the binary number can be divided by 2..
        if (isDigitOne % 2 == 0)
        {
            // ..print on the console
            Console.WriteLine("The binary representation of the number {0} is {1}" + Environment.NewLine +
                              "The third digit of the binaty number is 0!", number, binary);
        }

        // If the binary number can NOT be divided by 2..
        else
        {
            // ..print on the console
            Console.WriteLine("The binary representation of the number {0} is {1}" + Environment.NewLine +
                              "The third digit of the binaty number (counting from 0) is 1!", number, binary);
        }
    }
}