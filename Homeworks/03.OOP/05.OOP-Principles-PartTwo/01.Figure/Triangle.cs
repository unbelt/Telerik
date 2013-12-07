using System;

class Triangle : Shape
{
    public Triangle(double width, double height)
    {
        this.height = height;
        this.width = width;
    }

    public override double CalculateSurface()
    {
        return (height * width) / 2;
    }
}