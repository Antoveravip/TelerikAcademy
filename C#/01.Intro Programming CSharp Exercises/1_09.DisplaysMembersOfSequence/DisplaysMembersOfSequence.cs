/* Lesson 1 - Introduction to Programming
 * Homework 9
 * Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

using System;

class DisplaysMembersOfSequence
{
    static void Main()
    {
        sbyte begin = 2;
        sbyte member = 10;
        for (sbyte num = begin; num < begin + member; num++)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num * 1);
            }
            else
            {
                Console.WriteLine(num * (-1));
            }
        }
    }
}