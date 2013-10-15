using System;
using System.Text;

class SubstringЕxtension
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();
        input.Append("OneTwoThree");
        Console.WriteLine(input.Substring(3, 3));
    }
}