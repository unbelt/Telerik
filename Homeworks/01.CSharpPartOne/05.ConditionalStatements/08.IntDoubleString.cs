// Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {
        // Choose your destiny
        Console.WriteLine("1 for string" + Environment.NewLine +
                          "2 for int" + Environment.NewLine +
                          "3 for double");
        Console.Write("Choose: ");
        char choose = char.Parse(Console.ReadLine());

        // Switch to user choose
        switch (choose)
        {
            // if string
            case '1':
                Console.WriteLine("Enter a string: ");
                string strInput = Console.ReadLine();
                Console.WriteLine("Your input: {0}*", strInput);
                break;
            // if int
            case '2':
                Console.WriteLine("Enter a number (int): ");
                int intInput = int.Parse(Console.ReadLine());
                int intOutput = intInput + 1;
                Console.WriteLine("Your input: {0}" + Environment.NewLine + "Output: {1}", intInput, intOutput);
                break;
            // if double
            case '3':
                Console.WriteLine("Enter a number (double): ");
                double dblInput = double.Parse(Console.ReadLine());
                double dblOutput = dblInput + 1.0;
                Console.WriteLine("Your input: {0}" + Environment.NewLine + "Output: {1}", dblInput, dblOutput);
                break;
            // if goes wrong
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}