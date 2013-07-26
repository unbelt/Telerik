// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class Program
{
    static void Main()
    {
        // Get the radius of the circle
        Console.Write("Enter the radius of the circle: ");
        int radius = int.Parse(Console.ReadLine());

        // Calculates the perimeter
        int perimeter = 2 * radius;

        // Calculates the area
        double area = Math.PI * ((double)radius * (double)radius);

        // Print the result on the console
        Console.WriteLine("The radius of the circel is {0}, the perimeter {1}, and the area: {2}.", radius, perimeter, area);
    }
}