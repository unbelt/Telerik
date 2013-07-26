// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        // Declaring needed variables
        float height;
        float width;
        float area;

        // Get the height of the rectangle
        Console.Write("Enter the height of the rectangle: ");
        height = float.Parse(Console.ReadLine());

        // Get the width of the rectangle
        Console.Write("Enter the width of the rectangle: ");
        width = float.Parse(Console.ReadLine());

        // Calculates the area of the rectangle
        area = width * height;

        // Print on the console
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}