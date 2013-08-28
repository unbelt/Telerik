using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that extracts from given XML file all the text without the tags.
// Example:
// <?xml version="1.0"><student><name>Pesho</name>
// <age>21</age><interests count="3"><interest>
// Games</instrest><interest>C#</instrest><interest>
// Java</instrest></interests></student>

class RemoveXMLTags
{
    static void Main()
    {
        var xmlFile = File.ReadAllText("file.xml");
        var extractedText = "ExtractedText.txt";

        var pattern = "<[^>]+>"; // to remove xml tags

        // extracting text using regex
        File.WriteAllText(extractedText, Regex.Replace(xmlFile, pattern, string.Empty));

        Console.Write("[DONE] Open file? [Y/N]: ");
        OpenFile(extractedText);
    }
    static void OpenFile(string extractedText)
    {
        string readKey = Console.ReadLine().ToLower();

        switch (readKey)
        {
            case "y": Process.Start(extractedText);
                break;
            default: return;
        }
    }
}