using System;
using System.IO;
using System.Text.RegularExpressions;
// Write a program that replaces in a html document given as string all the tags <a href="…">…
// with corresponding tags [URL=…]…/URL]. Sample html fragment:
//      <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course.
//      Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
// Output:
//      <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course.
//      Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

class ReplacehtmlTags
{
    static void Main()
    {
        using (StreamReader htmlText = new StreamReader("htmlText.txt")) // original text at [bin/Debug/] folder
        {
            string text = htmlText.ReadToEnd();

            string replaceTags = Regex.Replace(text, "<a href=\"", "[URL=");
            replaceTags = Regex.Replace(replaceTags, @"</a>", "[/URL]");
            replaceTags = Regex.Replace(replaceTags, "\">", "]");

            Console.WriteLine(replaceTags);
        }
    }
}