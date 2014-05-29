using System;

/* 1. Refactor the code to use proper variable naming and simplified expressions. */

public class Size
{
    public static Coordinates GetRotatedSize(Coordinates coordinates, double angle)
    {
        double angleSin = Math.Abs(Math.Sin(angle));
        double angleCos = Math.Abs(Math.Cos(angle));

        return new Coordinates((angleCos * coordinates.Width) - (angleSin * coordinates.Height),
                               (angleSin * coordinates.Width) + (angleCos * coordinates.Height));
    }

    public struct Coordinates
    {
        public Coordinates(double width, double height)
            : this()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }
    }

    public static void Main()
    {
        Coordinates coordinate = new Coordinates(10, 20);
    }
}