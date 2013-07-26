// Declare a character variable and assign it with the symbol that has Unicode code 72.
// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class UnicodeSymbol
{
    static void Main()
    {
        /* Declare the variable */
        char unicodeSymbol = (char)0x48;

        /* Print on the console */
        Console.WriteLine(unicodeSymbol + Environment.NewLine);
    }
}