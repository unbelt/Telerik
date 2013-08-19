using System;
using System.Linq;
// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

public class ArraySortMethod
{
    public static void Main() // public Method
    {
        // array example
        string[] unsortedStr = { "Pesho", "Penka", "Cars", "Somelongword", "Yes", "No" };
        Console.WriteLine();

        // sort with Linq help ^_^
        var sortedStr = unsortedStr.OrderBy(uStr => uStr.Length);

        // printing
        foreach (var item in sortedStr)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}