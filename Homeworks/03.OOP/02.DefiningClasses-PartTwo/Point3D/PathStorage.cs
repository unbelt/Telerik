using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// 4.1 Create a static class PathStorage with static methods to save and load paths from a text file.
public static class PathStorage
{
    private const string savedPaths = "../../SavedPaths.txt";

    public static void SavePoint(Path path)
    {
        try
        {
            // 4.2 Use a file format of your choice.
            StreamWriter savePath = new StreamWriter(savedPaths);

            using (savePath)
            {
                foreach (var point in path.PathList)
                {
                    savePath.WriteLine(point);
                }
            }
        }
        catch (IOException IO)
        {
            Console.WriteLine(IO.Message);
        }
    }

    // Loading the points from file
    public static void LoadPoint()
    {
        StreamReader loadPath = new StreamReader(savedPaths);
        Path loadedPath = new Path();

        using (loadPath)
        {
            string line = loadPath.ReadLine();
            while (line != null)
            {
                string[] currentLine = line.Split(new char[] { ' ', ',', '=' }, StringSplitOptions.RemoveEmptyEntries);

                Point3D currentPath = new Point3D(int.Parse(currentLine[1]),
                                                  int.Parse(currentLine[3]),
                                                  int.Parse(currentLine[5]));
                loadedPath.AddPoint(currentPath);

                line = loadPath.ReadLine();
            }
        }

        // Printing
        foreach (var path in loadedPath.PathList)
        {
            Console.WriteLine(path);
        }
    }
}