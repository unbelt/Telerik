// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumWithAccuracy
{
    static void Main()
    {
        decimal sum = 1;
        decimal prevSum = 1;
        decimal divider = 2;
        int sign = 1;

        do
        {
            prevSum = sum;
            sum = sum + sign * (1 / divider++);
            sign *= -1;
        }
        while (Math.Abs(sum - prevSum) > (decimal)0.0001);

        Console.WriteLine("The sum with accuracy of 0.001 = {0:F4}", prevSum);
    }
}