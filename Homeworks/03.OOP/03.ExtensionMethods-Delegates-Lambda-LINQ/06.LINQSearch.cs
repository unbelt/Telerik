using System;
using System.Linq;
/* 6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
      Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ. */

class LINQSearch
{
    static void Main()
    {
        var numbers = new[] { 3, 7, 21, 35, 42 };

        var result = numbers.Where(number => number % 21 == 0);

        var linqResult = (
            from n in numbers
            where n % 21 == 0
            select n
            );

        Console.WriteLine("Lambda expression:");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        Console.WriteLine("LINQ expression:");
        foreach (var number in linqResult)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}
