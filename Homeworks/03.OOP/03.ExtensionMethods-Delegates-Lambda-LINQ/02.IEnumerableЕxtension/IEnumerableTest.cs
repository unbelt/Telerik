using System;

class IEnumerableTest
{
    static void Main()
    {
        var numbers = new[] { 3, 5, 12, 15, 30, 35 };

        Console.WriteLine("Sum: {0}", numbers.Sum());
        Console.WriteLine("Product: {0}", numbers.Product());
        Console.WriteLine("Min: {0}", numbers.Min());
        Console.WriteLine("Max: {0}", numbers.Max());
        Console.WriteLine("Average: {0}", numbers.Average());

        Console.WriteLine();
    }
}