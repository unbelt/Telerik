using System;
using System.Collections.Generic;
/* 1. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
      Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
      (height*width for rectangle and height*width/2 for triangle).
      Define class Circle and suitable constructor so that at initialization height must be kept equal to width and
      implement the CalculateSurface() method.
      Write a program that tests the behavior of  the CalculateSurface() method for different shapes
      (Circle, Rectangle, Triangle) stored in an array. */

class FigureTest
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Rectangle(10, 10),
            new Triangle(3, 5),
            new Circle(3.3),
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine("Surface of the {0}: {1:0.0}",  shape.GetType().Name, shape.CalculateSurface());
        }
    }
}