using System;

/* Refactor the following loop */

public class Loop
{
    public static bool Contains(int[] array, int expectedValue)
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == expectedValue)
            {
                return true;
            }
        }

        return false;
    }

    public static void Main()
    {
        int[] array = new int[] { 3, 5, 12, -4, 50, -55 };

        if (Contains(array, 12))
        {
            Console.WriteLine("Value Found");
        }
        else
        {
            Console.WriteLine("Value NOT Found");
        }
    }
}