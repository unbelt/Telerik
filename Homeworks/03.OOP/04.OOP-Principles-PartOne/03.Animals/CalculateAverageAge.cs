using System;
using System.Collections.Generic;
using System.Linq;

public static class CalculateAverageAge
{
    public static void CalculateAge(List<Animals> animals, string type)
    {
        var ages =
            from a in animals
            where a.GetType().Name == type
            select a.Age;

        Console.WriteLine("The average age of all {0}s is {1} years old.", type.GetType().Name, ages.Average());
    }
}