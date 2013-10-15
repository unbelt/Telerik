using System;
using System.Text;
/* 1. Implement an extension method Substring(int index, int length) for the class StringBuilder
      that returns new StringBuilder and has the same functionality as Substring in the class String. */


public static class SBExtension
{
    public static StringBuilder Substring(this StringBuilder input, int index, int length)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            result.Append(input[index].ToString());
            index++;
        }

        return result;
    }
}