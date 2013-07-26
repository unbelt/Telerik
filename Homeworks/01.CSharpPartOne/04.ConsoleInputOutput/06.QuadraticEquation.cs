// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it
// (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter C: ");
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
            Console.WriteLine("Equation have 1 real root x = {0}", x);
        }
        else
	    {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have two real roots: x1 = {0} and x2 = {1}", x1, x2);
	    }
    }
}