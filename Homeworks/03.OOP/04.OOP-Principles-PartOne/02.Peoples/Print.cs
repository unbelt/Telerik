using System;
using System.Collections.Generic;
using System.Text;

static class Print
{
    public static void Printer(this IEnumerable<object> list)
    {
        foreach (object item in list)
        {
            Console.WriteLine(item + Environment.NewLine);
        }
    }
}