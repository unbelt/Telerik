// 13. * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Text;

class MergeSortAlgorithm // With some help from the web
{
    // Main magic
    static public void DoMerge(int[] numbers, int left, int mid, int right)
    {
        // help variables
        int[] temp = new int[25];
        int i = 0;
        int leftEnd = 0;
        int numElements = 0;
        int tmpPos = 0;

        leftEnd = (mid - 1);
        tmpPos = left;
        numElements = (right - left + 1);

        while ((left <= leftEnd) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[tmpPos++] = numbers[left++];
            }
            else
            {
                temp[tmpPos++] = numbers[mid++];
            }
        }

        while (left <= leftEnd)
        {
            temp[tmpPos++] = numbers[left++];
        }

        while (mid <= right)
        {
            temp[tmpPos++] = numbers[mid++];
        }

        for (i = 0; i < numElements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    // Recursive logic
    static public void MergeSortRecursive(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSortRecursive(numbers, left, mid);
            MergeSortRecursive(numbers, (mid + 1), right);
            DoMerge(numbers, left, (mid + 1), right);
        }
    }

    // Printing
    static void Main(string[] args)
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        int len = 9;

        Console.WriteLine("MergeSort by recursive method:");
        MergeSortRecursive(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}