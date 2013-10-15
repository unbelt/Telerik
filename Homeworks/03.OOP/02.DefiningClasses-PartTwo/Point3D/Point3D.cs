using System.Text;

// 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
public struct Point3D
{
    // 2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    private static readonly Point3D PointO = new Point3D(0, 0, 0);

    // Constructor
    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    // Properties
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    // 1.1 Implement the ToString() to enable printing a 3D point.
    public override string ToString()
    {
        StringBuilder format = new StringBuilder();
        format.AppendFormat("X = {0}, Y = {1}, Z = {2}", X, Y, Z);
        return format.ToString();
    }
}