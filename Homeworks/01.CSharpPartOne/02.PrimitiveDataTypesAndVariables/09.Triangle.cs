// Write a program that prints an isosceles triangle of 9 copyright symbols ©.
// Use Windows Character Map to find the Unicode code of the © symbol.
// Note: the © symbol may be displayed incorrectly.

using System;
using System.Text; /* Needed for trademark symbol */

class Triangle
{
    static void Main()
    {
        /* Change encoding to UTF8 (for proper print of the trademark symbol) */
        Console.OutputEncoding = Encoding.UTF8;

        /* You now going to form a MEGAZORD */
        Console.Write("Enter a number to form a MEGAZORD:" + Environment.NewLine);

        /* Makes variable with default row count */
        int rowCount = 0;

        /* Makes bool variable for validation */
        bool isValid;

        /* Tries to read inputted data */
        do
        {
           isValid = int.TryParse(Console.ReadLine(), out rowCount);
           Console.WriteLine("Please enter a number between 0 and 20." + Environment.NewLine);
        }

        /* Makes an exeption to read only numbers between 0 and 20 */
        while (rowCount > 20 || rowCount < 1 || isValid == false);

        /* Makes a cycle for the rows count */
        for (int row = 0; row < rowCount; row++)
        {
            /* Makes a cycle for the cols count */
            for (int col = 0; col < rowCount * 1; col++)
            {
                /* Here goes the magic */
                if (row + col > rowCount - 1)
                {
                    /* Print the copyright symbols on the console */
                    Console.Write("\u00a9\u00a9");
                }
                else
                {
                    /* Print the blank spaces before the first copyright symbol */
                    Console.Write(" ");
                }
            }
            /* Print the top of the triangle */
            Console.WriteLine("\u00a9");
        }

        /* Print how stupid I am */
        Console.WriteLine("\n Just a joke, it's a triangle :)" + Environment.NewLine);
    }
}