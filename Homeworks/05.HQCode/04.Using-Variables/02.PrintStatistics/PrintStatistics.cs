using System;

/* 2. Refactor the code to apply variable usage and naming best practices. */

public class PrintStatistics
{
    public static int GetArrayLength(double[] array, int count)
    {
        if (count == -1)
        {
            return array.Length;
        }

        return count;
    }

    public static double GetMax(double[] inputArray, int arrayLength = -1)
    {
        arrayLength = GetArrayLength(inputArray, arrayLength);

        double maxElement = inputArray[0];

        for (int i = 1; i < arrayLength; i++)
        {
            if (maxElement < inputArray[i])
            {
                maxElement = inputArray[i];
            }
        }

        return maxElement;
    }

    public static double GetMin(double[] inputArray, int arrayLength = -1)
    {
        arrayLength = GetArrayLength(inputArray, arrayLength);

        double minElement = inputArray[0];

        for (int i = 1; i < arrayLength; i++)
        {
            if (minElement > inputArray[i])
            {
                minElement = inputArray[i];
            }
        }

        return minElement;
    }

    public static double GetSum(double[] inputArray, int arrayLength = -1)
    {
        arrayLength = GetArrayLength(inputArray, arrayLength);

        double sum = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            sum += inputArray[i];
        }

        return sum;
    }

    public static double GetAverage(double[] inputArray, int arrayLength = -1)
    {
        arrayLength = GetArrayLength(inputArray, arrayLength);
        return GetSum(inputArray, arrayLength) / arrayLength;
    }

    public static void Main()
    {
        double[] numbers = new double[] { 1.12, 2, 3, 4, -5, -50.5, 100 };

        Console.WriteLine(GetMax(numbers, 3));
        Console.WriteLine(GetMin(numbers, 5));
        Console.WriteLine(GetAverage(numbers));
    }
}