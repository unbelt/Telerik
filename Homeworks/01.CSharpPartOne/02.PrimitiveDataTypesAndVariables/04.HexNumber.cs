// Declare an integer variable and assign it with the value 254 in hexadecimal format.
// Use Windows Calculator to find its hexadecimal representation.

using System;

class HexNumber
{
    static void Main()
    {
        /* Declare the variable */
        int number = 0xFE;

        /* Print on the console */
        Console.WriteLine("254 in hexadecimal format is: 0x{0:X}", number + Environment.NewLine);
    }
}