/* Lesson 9 - Strings and Text Processing
 * Homework 7
 * 
 * Write a program that encodes and decodes a string
 * using given encryption key (cipher). The key consists
 * of a sequence of characters. The encoding/decoding is
 * done by performing XOR (exclusive or) operation over 
 * the first letter of the string with the first of the
 * key, the second – with the second, etc. When the last
 * key character is reached, the next is the first.
 */

using System;
using System.Text;

class DecodesAndEncodesString
{
    static void Main()
    {
        //Test string
        string secretMessage = "Write a program that encodes and decodes a string using given encryption key.";
        string keyWord = "1wtf2";
        /*
        //Strings inputed from console
        Console.Write("Write some text: ");
        string secretMessage = Console.ReadLine();
        Console.Write("Write key word to encodes and decodes the message: ");
        string keyWord = Console.ReadLine();
        */
        string encodedMsg = EncoderDecoder(secretMessage, keyWord);
        Console.WriteLine("Encoded message: {0}", encodedMsg);

        string decodedMsg = EncoderDecoder(encodedMsg, keyWord);
        Console.WriteLine("Decoded message: {0}", decodedMsg);
    }

    static string EncoderDecoder(string message, string keyWord)
    {
        var specialMessage = new StringBuilder(message.Length);

        for (int i = 0; i < message.Length; i++)
        {
            int special = keyWord[i % keyWord.Length];
            specialMessage.Append((char)(message[i] ^ special));
        }
        return specialMessage.ToString();
    }
}