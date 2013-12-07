using System;
class Circle : Shape
{
    public Circle(double radius)
    {
        this.width = radius;
    }

    public override double CalculateSurface()
    {
        return (Math.PI * Math.Pow(width, 2));
    }
}