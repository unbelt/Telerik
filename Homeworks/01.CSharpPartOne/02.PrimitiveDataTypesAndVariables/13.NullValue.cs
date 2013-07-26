// Create a program that assigns null values to an integer and to double variables.
// Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

namespace NullValues
{
    class NullValues
    {
        static void Main()
        {
            /* Declarie two variables with number values */
            int number1 = 15;
            double number2 = 12.355013;

            /* Declarie two variables with null value */
            int? nullNumber1 = null;
            double? nullNumber2 = null;

            /* Declarie object variable that add 1 to nulled variable */
            object nullPlusOne = nullNumber1 + 1;

            /* Print all the variable values on the console */
            Console.WriteLine("Nulled integer ({0}) = {1}", number1, nullNumber1);
            Console.WriteLine("Nulled double ({0}) = {1}", number2, nullNumber2);
            Console.WriteLine("Nulled number + 1 = {0}", nullPlusOne + Environment.NewLine);
        }
    }
}