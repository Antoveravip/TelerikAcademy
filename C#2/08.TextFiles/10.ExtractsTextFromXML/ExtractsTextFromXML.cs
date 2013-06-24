/* Lesson 9 - Text Files
 * Homework 10
 * 
 * Write a program that extracts from given 
 * XML file all the text without the tags.
 * Example:
 * <?xml version="1.0"><student><name>Pesho</name>
 * <age>21</age><interests count="3"><interest>
 * Games</instrest><interest>C#</instrest><interest>
 * Java</instrest></interests></student>
 */

using System;
using System.IO;

class ExtractsTextFromXML
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../inputData.txt"))
        {
            int charValue = input.Read();
            while(charValue != -1)
            {
                if (charValue == '>')
                {
                    string text = String.Empty;
                    while ((charValue = input.Read()) != -1 && charValue != '<')
                    {
                        text += (char)charValue;
                    }
                    if (text.Length !=0 && !String.IsNullOrWhiteSpace(text) && charValue == '<')
                    {
                        Console.WriteLine(text.Trim());
                    }
                }
                charValue = input.Read();
            }
        }
    }
}