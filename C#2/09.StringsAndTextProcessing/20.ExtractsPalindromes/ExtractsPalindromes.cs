/* Lesson 9 - Strings and Text Processing
 * Homework 20
 * 
 * Write a program that extracts from a given text 
 * all palindromes, e.g. "ABBA", "lamal", "exe".
 */

using System;

class ExtractsPalindromes
{
    static void Main()
    {
        //Test data
        string inputData = @"ABBA. lamal, exe, Ana, This, anna, or еlle, even еve, best hanah, may Hannah";

        /*
        //Data inputed from console
        Console.Write("Enter word to check if is palindrome: ");
        string inputData = Console.ReadLine();
        */

        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] divided = inputData.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in divided)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}