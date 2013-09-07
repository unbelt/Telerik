using System;
using System.Text;
// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
// operation over the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

class StringEncryption
{
    static void Main()
    {
        string text = "some text";
        string key = "ab";

        Console.WriteLine("Encoded text: ");
        Console.WriteLine(EncodeDecode(text, key));
        Console.WriteLine();

        Console.WriteLine("Decoded text: ");
        Console.WriteLine(EncodeDecode(EncodeDecode(text, key), key));
        Console.WriteLine();
    }

    static string EncodeDecode(string text, string key)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            int charCode = (int)character;
            int keyPosition = i % key.Length;
            char keyChar = key[keyPosition];
            int keyCode = (int)keyChar;
            int combinedCode = charCode ^ keyCode; // performing XOR
            char combinedChar = (char)combinedCode;

            result.Append(combinedChar);
        }

        return result.ToString();
    }
}