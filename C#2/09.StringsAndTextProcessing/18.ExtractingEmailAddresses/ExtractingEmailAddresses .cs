/* Lesson 9 - Strings and Text Processing
 * Homework 18
 * 
 * Write a program for extracting all email addresses
 * from given text. All substrings that match the format 
 * <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;


class ExtractingEmailAddresses
{
    static void Main()
    {
        //Test emails
        string inputData = "Please contact us by phone (+359 2 999 99 99) or by email at office@companyname.bg or at sales@companyname.bg.";
        //string inputData = "Not valid or correct emails: garb@bor., @gtrash.com., 7a@ri.j.";

        /*
        //Data inputed from console
        Console.Write("Write contact informations with email: ");
        string inputData = Console.ReadLine();
        */

        string[] dividedInput = inputData.Split(' ');

        for (int i = 0; i < dividedInput.Length; i++)
        {
            string currentPhrase = dividedInput[i];

            if (currentPhrase[currentPhrase.Length - 1] == '.')
                dividedInput[i] = currentPhrase.Remove(currentPhrase.Length - 1);
        }

        bool hasIdentifier = false;
        bool hasHostAndDomain = false;

        for (int i = 0; i < dividedInput.Length; i++)
        {
            if (!IsCorrectPhrase(dividedInput[i]))
            {
                continue;
            }

            int indexAt = dividedInput[i].IndexOf("@");

            if (indexAt > 3)
            {
                hasIdentifier = true;
            }

            int indexDot = dividedInput[i].IndexOf(".", indexAt + 1);

            if (indexDot > indexAt + 1)
            {
                hasHostAndDomain = true;
            }

            if (hasIdentifier & hasHostAndDomain)
            {
                if ((dividedInput[i].Substring(indexDot, dividedInput[i].Length - indexDot - 1)).Length > 1)
                {
                    Console.WriteLine(dividedInput[i]);
                }
            }
            if (i == dividedInput.Length - 1 && (!hasIdentifier || !hasHostAndDomain))
            {
                Console.WriteLine("There is no correct and valid email addresses!");
            }


            hasIdentifier = false;
            hasHostAndDomain = false;
        }
    }

    static bool IsCorrectPhrase(string inputData)
    {
        bool isCorrectChar = true;

        string correctChars = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM@.-_";

        for (int i = 0; i < inputData.Length; i++)
        {
            int index = correctChars.IndexOf(inputData[i]);

            if (index < 0)
            {
                isCorrectChar = false;
                break;
            }
        }

        return isCorrectChar;
    }
}