using System;
using System.Collections.Generic;
using System.IO;

// 4. Create a class Path to hold a sequence of points in the 3D space.
public class Path
{
    public List<Point3D> PathList = new List<Point3D>();

    public void AddPoint(Point3D path)
    {
        PathList.Add(path);
    }

    public void Clear()
    {
        PathList.Clear();
    }
}