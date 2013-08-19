using System;
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
// Use try-catch-finally.

class TryCatchFinally
{
    static void Main()
    {
        Console.Write("Enter a number to calculate its square root: ");

        try
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {

            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {

            Console.WriteLine("Invalid number!");
        }
        finally // execute always
        {
            Console.WriteLine("Good bye!");
        }
    }
}