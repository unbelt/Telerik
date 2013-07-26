// 12. Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfEachLetter
{
    static void Main()
    {
        // get a word
        string word = Console.ReadLine();
        int[] array = new int[53];

        // loop for lowercases
        for (int i = 0; i < 26; i++)
        {
            array[i] = 'a' + i;
        }

        // loop for uppercases
        for (int i = 26, j = 0; i < 53; i++, j++)
        {
            array[i] = 'A' + j;
        }

        // printing
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (word[i] == array[j])
                {
                    Console.Write("{0}: ", word[i]);
                    Console.WriteLine(j);
                }
            }
        }
    }
}