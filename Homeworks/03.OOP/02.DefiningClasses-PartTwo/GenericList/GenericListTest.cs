using System;

class GenericListTest
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>();

        Console.WriteLine("Adding numbers:");
        list.AddElement(3);
        list.AddElement(5);
        list.AddElement(12);
        Console.WriteLine(list + Environment.NewLine); // Print

        Console.WriteLine("Inserting [-3] at position [2]");
        list.InsertElementAt(2, -3);
        Console.WriteLine(list + Environment.NewLine); // Print

        Console.WriteLine("Removing element at position [1]");
        list.RemoveElementAtIndex(1);
        Console.WriteLine(list + Environment.NewLine);

        Console.WriteLine("Search for number [-3]");
        Console.WriteLine(list.FindElementValue(-3) + Environment.NewLine);

        Console.WriteLine("STATISTICS");
        Console.WriteLine("Elements count: {0}", list.Count);
        Console.WriteLine("Min element: {0}", list.Min());
        Console.WriteLine("Max element: {0}", list.Max());

        list.ClearList();
        Console.WriteLine();
    }
}