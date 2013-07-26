// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
// Example: 3, -2, 1, 1, 8 -> 1 + 1 - 2 = 0.

using System;

class SubsetSum
{
    static void Main()
    {
        Console.Write("Enter the integer count: ");
        int count = int.Parse(Console.ReadLine());
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int subCount = 0;

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                sum = arr[i] + arr[j];
                if (sum == 0)
                {
                    subCount++;
                }
                for (int k = j + 1; k < count; k++)
                {
                    sum = sum + arr[k];
                    if (sum == 0)
                    {
                        subCount++;
                    }

                    for (int l = k + 1; l < count; l++)
                    {
                        sum = sum + arr[l];
                        if (sum == 0)
                        {
                            subCount++;
                        }
                        for (int m = l + 1; m < count; m++)
                        {
                            sum = sum + arr[m];
                            if (sum == 0)
                            {
                                subCount++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("The sum of {0} subset(s) is zero!", subCount);
    }
}