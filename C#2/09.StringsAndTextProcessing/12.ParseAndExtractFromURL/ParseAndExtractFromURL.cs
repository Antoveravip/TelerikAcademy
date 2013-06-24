/* Lesson 9 - Strings and Text Processing
 * Homework 12
 * 
 * Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * 
 * and extracts from it the [protocol], [server] and [resource] elements.
 * For example from the URL http://www.devbg.org/forum/index.php the
 * following information should be extracted:
 * 
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 */

using System;

class ParseAndExtractFromURL
{
    static void Main()
    {
        //Test URL
        string urlData = @"http://www.devbg.org/forum/index.php";
        /*
        //URL inputed from console
        Console.Write("Write any url: ");
        string urlData = Console.ReadLine();
        */

        int index2Dots = 0;
        int index2Slash = 0;
        int index1Slash = 2;

        for (int i = 0; i < urlData.Length - 2; i++)
        {
            if (urlData.Substring(i, 1) == ":")
            {
                index2Dots = i;
            }
            else if ((urlData.Substring(i, 2) == "//"))
            {
                index2Slash = i;
                for (int k = i + 3; k < urlData.Length; k++)
                {
                    if (urlData.Substring(k, 1) == "/")
                    {
                        index1Slash = k;
                        break;
                    }
                }
            }
        }
        int protokolLength = index2Dots;
        int serverLength = index1Slash - index2Slash - 1;
        int resourceLength = urlData.Length - 1 - index1Slash+1;

        string protokolId = urlData.Substring(0, protokolLength);
        string serverId = urlData.Substring(index2Slash + 2, serverLength - 1);
        string resourceId = urlData.Substring(index1Slash, resourceLength);

        Console.WriteLine(@"[protokol] = ""{0}""", protokolId);
        Console.WriteLine(@"[server] = ""{0}""", serverId);
        Console.WriteLine(@"[resource] = ""{0}""", resourceId);
    }
}