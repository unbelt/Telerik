using System;
using System.IO;

public class Point3DTest
{
    public static void Main()
    {
        // Make two points
        Point3D pointA = new Point3D(5, 6, 2);
        Point3D pointB = new Point3D(-7, 11, -13);

        // Print the points
        Console.WriteLine("Point a: {0}", pointA);
        Console.WriteLine("Point b: {0}", pointB);
        Console.WriteLine();

        // Calculate the distance
        double distance = Distance.CalculateDistance(pointA, pointB);
        Console.WriteLine("Distance [a -> b] = {0:0.00}", distance);

        // Add a points to the List<>
        Path path = new Path();
        //path.AddPoint(pointA);
        path.AddPoint(pointB);

        // Save the points from the List<> to .txt
        PathStorage.SavePoint(path);
        Console.WriteLine();

        // Load the points from the file
        Console.WriteLine("Loaded points:");
        PathStorage.LoadPoint();
        Console.WriteLine();
    }
}