using System;
using System.Collections;
using System.Collections.Generic;

static class Print
{
    public static void Printer(this IEnumerable<object> list)
    {
        foreach (object item in list)
        {
            Console.WriteLine(item);
        }
    }
}