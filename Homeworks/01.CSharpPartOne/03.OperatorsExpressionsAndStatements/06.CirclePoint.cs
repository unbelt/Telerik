// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class CirclePoint
{
    static void Main()
    {
        //Declaring needed variables
        float pointX;
        float pointY;

        // Get the point X
        Console.Write("Enter the point X: ");
        pointX = float.Parse(Console.ReadLine());

        // Get the point Y
        Console.Write("Enter the point Y: ");
        pointY = float.Parse(Console.ReadLine());

        // Checks if given point (X, Y) is within the circle
        bool isInCirle = (pointX - 0) * (pointX - 0) + (pointY - 0) * (pointY - 0) <= 5 * 5;

        // If the point is inside the circle..
        if (isInCirle)
        {
            // ..print on the console
            Console.WriteLine("Point({0}, {1}) is inside the circle!", pointX, pointY);
        }

        // If the point is NOT inside the circle.. 
        else
        {
            // ..print on the console
            Console.WriteLine("Point({0}, {1}) is NOT inside the circle!", pointX, pointY);
        }
    }
}