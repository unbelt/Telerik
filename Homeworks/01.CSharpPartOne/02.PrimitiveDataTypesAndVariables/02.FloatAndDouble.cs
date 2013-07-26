// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
// 34.567839023, 12.345, 8923.1234857, 3456.091 ?

using System;

class FloatAndDouble
{
    static void Main()
    {
        double number1 = 34.567839023; /* 15-16 digits */
        float number2 = 12.345f;       /* 7 digits */
        double number3 = 8923.1234857;
        float number4 = 3456.091f;

        /* Print the numbers on the console */
        Console.WriteLine("Example of double: " + number1);
        Console.WriteLine("Example of float: " + number2);
        Console.WriteLine("Example of double: " + number3);
        Console.WriteLine("Example of float: " + number4 + Environment.NewLine);
    }
}