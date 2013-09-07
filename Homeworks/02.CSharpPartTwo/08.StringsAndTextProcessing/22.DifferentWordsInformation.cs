using System;
using System.Linq;
using System.Collections.Generic;
// Write a program that reads a string from the console and lists all different words in the string
// along with information how many times each word is found.

class DifferentWordsInformation
{
    static void Main() // TODO: remove duplications
    {
        var words = "We are living in an yellow submarine. We don't have anything else.".Split()
            .Select(w => w.ToLower());

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!dictionary.Keys.Contains(word))
            {
                dictionary[word] = 1;
            }
            else
            {
                dictionary[word]++;
            }
        }

        foreach (KeyValuePair<string,int> item in dictionary)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}