// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console.

using System;
using System.Text; /* For some special symbols */

class ASCII
{
    static void Main()
    {
        /* Makes a cycle for the symbols */
        for (int symbol = 0; symbol <= 127; symbol++)
        {
            /* Print all the symbols from ASCII table on the console */
            Console.WriteLine("{0}: {1}", symbol, (char)symbol);
        }
    }
}