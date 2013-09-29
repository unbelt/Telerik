using System;
using System.Collections.Generic;
// http://bgcoder.com/Contest/Practice/92

class KaspichanNumbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        var numbers = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            numbers.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                numbers.Add(i.ToString() + j.ToString());
            }
        }

        string result = string.Empty;

        if (input == 0)
        {
            Console.WriteLine('A');
        }

        while (input != 0)
        {
            result = numbers[(int)(input % 256)] + result;
            input /= 256;
        }

        Console.WriteLine(result);
    }
}