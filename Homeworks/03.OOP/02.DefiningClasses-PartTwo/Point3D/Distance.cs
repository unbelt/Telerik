using System;
// 3. Write a static class with a static method to calculate the distance between two points in the 3D space.

public static class Distance
{
    public static double CalculateDistance(Point3D pointA, Point3D pointB)
    {
        double distance = 0;

        // Distance formula: http://en.wikipedia.org/wiki/Euclidean_distance
        distance = Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) +
                             Math.Pow(pointA.Y - pointB.Y, 2) +
                             Math.Pow(pointA.Z - pointB.Z, 2));
        return distance;
    }
}