using System;
// Write a program that reads a string from the console and prints all different letters in the string
// along with information how many times each letter is found. 

class DifferentLettersInformation
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else.".ToLower();

        int count = 0;

        for (int i = 97; i <= 122; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == Convert.ToChar(i))
                {
                    count++;
                }
                if (j == text.Length - 1 && count != 0)
                {
                    Console.WriteLine("{0}: {1} times", Convert.ToChar(i), count);
                }
            }

            count = 0;
        }
    }
}