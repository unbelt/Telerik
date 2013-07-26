// 3. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArrayComparison
{
    static void Main()
    {
        // Get the array size
        Console.Write("Size of the arrays: ");
        int length = int.Parse(Console.ReadLine());

        char[] firstArray = new char[length];
        char[] secondArray = new char[length];

        bool equal = true;

        for (int i = 0; i < length; i++)
        {
            // Read symbols for each array
            Console.Write("firstArray[{0}]: ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
            Console.Write("secondArray[{0}]: ", i);
            secondArray[i] = char.Parse(Console.ReadLine());

            // Comparing the arrays and printing the result
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] == secondArray[{1}]", i, i);
            }
            else
            {
                Console.WriteLine("firstArray[{0}] != secondArray[{1}]", i, i);
                equal = false;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Is the arrays equal: {0}", equal);
    }
}