using System;
// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("What do you know?" + Environment.NewLine);
        Console.WriteLine("1 -> Side and an altitude to it.");
        Console.WriteLine("2 -> Three sides.");
        Console.WriteLine("3 -> Two sides and an angle between them." + Environment.NewLine);

        Console.Write("Choose: ");
        int input = int.Parse(Console.ReadLine());

        switch (input) // switch between 3 formulas
        {
            case 1: SideAndAltitude(); break;
            case 2: ThreeSides(); break;
            case 3: TwoSidesAndAngle(); break;
            default: Console.WriteLine("Wrong Input!"); break;
        }
    }

    static void SideAndAltitude() // Formula: s = (b * h) / 2
    {
        Console.Write("Enter a side: ");
        double baseA = double.Parse(Console.ReadLine());

        Console.Write("Enter a altitude: ");
        double height = double.Parse(Console.ReadLine());

        double area = (baseA * height) / 2;
        Console.WriteLine("Area = {0}", area + Environment.NewLine);
    }

    static void ThreeSides() // Formula: s = sqrt(p * (p - a) * (p - b) * (p - c))
                             //          p = Perimeter / 2
    {
        Console.Write("Enter first side: ");
        double baseA = double.Parse(Console.ReadLine());

        Console.Write("Enter second side: ");
        double baseB = double.Parse(Console.ReadLine());

        Console.Write("Enter third side: ");
        double baseC = double.Parse(Console.ReadLine());

        double halfP = (baseA + baseB + baseC) / 2;

        double area = Math.Sqrt(halfP * (halfP - baseA) * (halfP - baseB) * (halfP - baseC));

        Console.WriteLine("Area = {0}", area + Environment.NewLine);
    }

    static void TwoSidesAndAngle() //Formula: s = (a * b * sin(C)) / 2
    {
        Console.Write("Enter first side: ");
        double baseA = double.Parse(Console.ReadLine());

        Console.Write("Enter second side: ");
        double baseB = double.Parse(Console.ReadLine());

        Console.Write("Enter angle degrees: ");
        double angleNumber = double.Parse(Console.ReadLine());

        double angleInDegrees = angleNumber * Math.PI / 180;

        double area = (baseA * baseB * Math.Sin(angleInDegrees)) / 2;

        Console.WriteLine("Area = {0}", area + Environment.NewLine);
    }
}
