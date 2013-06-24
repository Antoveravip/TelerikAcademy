/* Lesson 2 - Arrays
 * Homework 12
 * 
 * Write a program that creates an array containing all letters from
 * the alphabet (A-Z). Read a word from the console and print the
 * index of each of its letters in the array..
 */

using System;

class CreateCharArray
{
    static void Main()
    {
        char[] alphabetUppercase = new char[26];
        char[] alphabetLowercase = new char[26];
        char[] checkedArray = new char[26];
        string letterCase = "";
        byte alphabetLetterPosition = 0;

        for (int i = 0; i < alphabetUppercase.Length; i++)
        {
            alphabetUppercase[i] = (char)(65 + i);
            alphabetLowercase[i] = (char)(97 + i);
        }
        string inputWord = Console.ReadLine();
        for (int wordChar = 0; wordChar < inputWord.Length; wordChar++)
        {
            if (((int)(inputWord[wordChar]) >= 65) && ((int)(inputWord[wordChar]) <= 92))
            {
                checkedArray = alphabetUppercase;
                letterCase = "capital";
            }
            else if (((int)(inputWord[wordChar]) >= 97) && ((int)(inputWord[wordChar]) <= 122))
            {
                checkedArray = alphabetLowercase;
                letterCase = "small";
            }

            for (int letter = 0; letter < checkedArray.Length; letter++)
            {
                if (inputWord[wordChar] == checkedArray[letter])
                {
                    alphabetLetterPosition = (byte)(letter + 1);
                    Console.WriteLine("The {0} letter '{1}' is {2} letter in alphabet, and have index {3} in array.", letterCase, inputWord[wordChar], alphabetLetterPosition, letter);
                }
            }
        }
    }
}