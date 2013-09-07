using HtmlAgilityPack;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
// Write a program that extracts from given HTML file its title (if available),
// and its body text without the HTML tags. Example:
/*  <html>
      <head><title>News</title></head>
      <body><p><a href="http://academy.telerik.com">Telerik
        Academy</a>aims to provide free real-world practical
        training for young people who want to turn into
        skillful .NET software engineers.</p></body>
    </html>
*/

class RemoveHTMLTags
{
    static void Main()
    {
        string html = File.ReadAllText("htmlText.txt");

        // Ordinary Regex
        //string regex = "(?<=^|>)[^><]+?(?=<|$)";
        //MatchCollection text = Regex.Matches(html, regex);

        //foreach (var value in text)
        //{
        //    //Console.Write(value);
        //}

        // Tool for HTML extract (Html Agility Pack)
        HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
        htmlDoc.LoadHtml(html);
        Console.WriteLine(new StringBuilder().AppendLine(htmlDoc.DocumentNode.InnerText).ToString());
    }
}