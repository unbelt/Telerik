﻿using System;
using System.Text.RegularExpressions;
// Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". The text is:
// We are living in a yellow submarine. We don't have anything else.
// Inside the submarine is very tight. So we are drinking all the day.
// We will move out of it in 5 days.
//      The expected result is:
// We are living in a yellow submarine.
// We will move out of it in 5 days.
// Consider that the sentences are separated by "." and the words – by non-letter symbols.

class ExtractsText
{
    static void Main()
    {
        var text = @"We are living in a yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking all the day.
We will move out of it in 5 days.".Split(new[] {'.', '!', '?'});

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].IndexOf(" in ") != -1)
            {
                Console.Write("{0}.", text[i]);
            }
        }
        Console.WriteLine();
    }
}