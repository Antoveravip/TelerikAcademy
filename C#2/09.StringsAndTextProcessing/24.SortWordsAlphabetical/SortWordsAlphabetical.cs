/* Lesson 9 - Strings and Text Processing
 * Homework 24
 * 
 * Write a program that reads a list of words, separated
 * by spaces and prints the list in an alphabetical order.
 */

using System;

class SortWordsAlphabetical
{
    static void Main()
    {
        //Test text
        string inputData = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";

        /*
        //Data inputed from console
        Console.Write("Enter some text: ");
        string inputData = Console.ReadLine();
        */

        string[] wordsCont = inputData.Split(' ');

        Array.Sort(wordsCont);

        foreach (string word in wordsCont)
        {
            Console.WriteLine(word);
        }
    }
}