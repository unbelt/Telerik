// Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4.0 * a * c);
        if (d < 0)
        {
            Console.WriteLine("Equation do NOT have real roots!");
        }
        else if (d == 0)
        {
            d = Math.Sqrt(d);
            double x = (-b + d) / (2 * a);
            Console.WriteLine("Equation have 1 real root x = {0:0.##}", x);
        }
        else
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have two real roots: x1 = {0:0.##} and x2 = {1:0.##}", x1, x2);
        }
    }
}