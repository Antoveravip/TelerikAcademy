/* Lesson 9 - Strings and Text Processing
 * Homework 25
 * 
 * Write a program that extracts from given HTML file its title
 * (if available), and its body text without the HTML tags.
 * Example:
 * 
 * <html>
 * <head><title>News</title></head>
 * <body><p><a href="http://academy.telerik.com">Telerik
 * Academy</a>aims to provide free real-world practical
 * training for young people who want to turn into
 * skillful .NET software engineers.</p></body>
 * </html>
 */

using System;
using System.Text;

class ExtractTitleAndTextFromHTML
{
    static void Main()
    {
        //Test data
        string inputData = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        /*
        //Data inputed from console
        Console.Write("Enter text to check how many times is used each word: ");
        string inputData = Console.ReadLine();
        */

        inputData = inputData.Replace("\n", "");
        string openTitleTag = "<title>";
        string closingTitleTag = "</title>";
        string openBodyTag = "<body>";
        int index;
        if ((index = inputData.IndexOf(openTitleTag, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            string title = inputData.Substring(index, inputData.IndexOf(closingTitleTag, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(ExtractTextBetweenTags(title));
        }
        if ((index = inputData.IndexOf(openBodyTag, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            string body = inputData.Substring(index, inputData.Length - index);
            Console.WriteLine(ExtractTextBetweenTags(body));
        }
    }

    static string ExtractTextBetweenTags(string inputCode)
    {
        bool openTag = false;
        bool closeTag = false;
        StringBuilder textOnly = new StringBuilder();
        for (int i = 0; i < inputCode.Length; i++)
        {
            if (inputCode[i] == '<')
            {
                openTag = true;
            }
            if (closeTag && !openTag)
            {
                textOnly.Append(inputCode[i]);
            }
            if (inputCode[i] == '<' && closeTag)
            {
                openTag = true;
                closeTag = false;
            }
            if (inputCode[i] == '>' && openTag)
            {
                closeTag = true;
                openTag = false;
            }
        }
        return textOnly.ToString();
    }
}