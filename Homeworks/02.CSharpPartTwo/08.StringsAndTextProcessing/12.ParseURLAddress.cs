using System;
using System.Text.RegularExpressions;
using System.Linq;
// Write a program that parses an URL address given in the format:
//      [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements.
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

class ParseURLAddress 
{
    static void Main()
    {
        string url = @"http://www.devbg.org/forum/index.php";

        string regex = @"(?<protocol>^(ht|f)tp(s?))\:\/\/(?<server>(?:www\.)?[a-zA-Z0-9\.]+\.[a-z]{2,4})(?<resource>.*)";

        if (Regex.IsMatch(url, regex))
        {
            MatchCollection collection = Regex.Matches(url, regex);

            foreach (Match m in collection)
            {
                Console.WriteLine("[protocol] = {0}", m.Groups["protocol"].Value);
                Console.WriteLine("[server] = {0}", m.Groups["server"].Value);
                Console.WriteLine("[resource] = {0}", m.Groups["resource"].Value);
            }
        }
        else
        {
            Console.WriteLine("Invalid URL!");
        }
    }
}