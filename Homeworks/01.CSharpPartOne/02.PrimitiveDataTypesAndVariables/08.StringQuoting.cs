// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings.
using System;

class StringQuoting
{
    static void Main()
    {
        /* First string with escaping */
        string quoting = "First string: The \"use\" of quotations causes difficulties.";

        /* Second string with escaping */
        string quoting2 = @"Second string: The ""use"" of quotations causes difficulties.";

        /* Print on the console */
        Console.WriteLine(quoting);
        Console.WriteLine(quoting2 + Environment.NewLine);
    }
}