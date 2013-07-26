// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        // Declaring needed variables
        double base1;
        double base2;
        double height;

        // Get the first base
        Console.Write("Enter the first base: ");
        base1 = double.Parse(Console.ReadLine());

        // Get the second base
        Console.Write("Enter the second base: ");
        base2 = double.Parse(Console.ReadLine());

        // Get the height
        Console.Write("Enter the height: ");
        height = double.Parse(Console.ReadLine());

        // Calculates the area of the trapezoid
        double faceOfTrap = height * ((base1 + base2) / 2);

        // Print on the console the area of the trapezoid
        Console.WriteLine("The area of the trapezoid is: {0}", faceOfTrap);
    }
}