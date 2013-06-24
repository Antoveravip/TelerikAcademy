/* Lesson 2 - Primitive Data Types and Variables
 * Homework 9
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 * Use Windows Character Map to find the Unicode code of the © symbol.
 * Note: the © symbol may be displayed incorrectly.
 */

using System;
using System.Text;

class CopyrightSymbols
{
    static void Main(string[] args)
    {
        //All roads lead to Rome!
        //Some are harder and travel takes more resources, others are easier but with less impressions!
        Console.WriteLine("All roads lead to Rome!\nSome are harder and travel takes more resources,\nothers are easier but with less impressions!\n");
        //One way ...
        Console.OutputEncoding = Encoding.Unicode;
        char copyRight = '\u00A9';
        char emptySpace = '\u00A0';
        Console.WriteLine("One way ...");
        Console.WriteLine();
        Console.WriteLine("\u00A0\u00A0\u00A0\u00A9");
        Console.WriteLine("\u00A0\u00A0\u00A9\u00A9\u00A9");
        Console.WriteLine("\u00A0\u00A9\u00A9\u00A9\u00A9\u00A9");
        Console.WriteLine();
        // ...or another ....
        Console.WriteLine("... or another ...\n");
        Console.WriteLine("{0}{0}{0}{1}", emptySpace, copyRight);
        Console.WriteLine("{0}{0}{1}{1}{1}", emptySpace, copyRight);
        Console.WriteLine("{0}{1}{1}{1}{1}{1}", emptySpace, copyRight);
        // ...or ....
        Console.WriteLine("\n... or ...\n");
        byte counter = 1;
        byte row = 3;
        byte col = (byte)(2 * row - 1);
        for (byte i = 0; i < row; i++)
        {
            for (byte k = 0; k < col; k++)
            {
                if (k == 0)
                {
                    Console.Write(emptySpace);
                }
                if (k < ((col - counter) / 2) || k > ((col + counter) / 2 - 1))
                {
                    Console.Write(emptySpace);
                }
                else
                {
                    Console.Write(copyRight);
                }
            }
            counter = (byte)(counter + 2);
            Console.WriteLine();
        }
        // ... etc....
        Console.WriteLine("\n...etc ...");
    }
}