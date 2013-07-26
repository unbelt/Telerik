// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CircleAndRectanglePoint
{
    static void Main()
    {
        // Get the point X
        Console.Write("Enter the point X: ");
        float pointX = float.Parse(Console.ReadLine());

        // Get the point Y
        Console.Write("Enter the point Y: ");
        float pointY = float.Parse(Console.ReadLine());

        Console.Write("The point ({0}, {1}) is ", pointX, pointY);

        // Checks if given point (X, Y) is within the circle
        bool isInCirle = (pointX - 0) * (pointX - 0) + (pointY - 0) * (pointY - 0) <= 5 * 5;

        // If the point is inside the circle..
        if (isInCirle)
        {
            // ..print on the console
            Console.Write("inside the circle and ");
        }

        // If the point is NOT inside the circle.. 
        else
        {
            // ..print on the console
            Console.Write("outside the circle and ");
        }

        // Checks if given point (X, Y) is within the rectangle
        bool isInRectangleX = pointX <= 5 && pointX >= -1;
        bool isInRectangleY = pointY <= 1 && pointY >= -1;

        // If the point is inside the rectangle..
        if (isInRectangleX && isInRectangleY)
        {
            // ..print on the console
            Console.WriteLine("inside of the rectangle!");
        }

        // If the point is NOT inside the rectangle.. 
        else
        {
            // ..print on the console
            Console.WriteLine("outside of the rectangle!");
        }
    }
}