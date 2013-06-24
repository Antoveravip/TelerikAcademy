﻿/* Lesson 3 - Linear Data Structures
 * Homework 9
 * 
 * We are given the following sequence:
 * S1 = N;
 * S2 = S1 + 1;
 * S3 = 2*S1 + 1;
 * S4 = S1 + 2;
 * S5 = S2 + 1;
 * S6 = 2*S2 + 1;
 * S7 = S2 + 2;
 * ...
 * Using the Queue<T> class write a program 
 * to print its first 50 members for given N.
 * Example:
 * N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
 */

namespace _09.CalculateAndPrintSequence
{
    using System;
    using System.Collections.Generic;

    public static class Sequence
    {
        public static void Main()
        {
            int members = 50;
            Queue<int> sequence = new Queue<int>();
            
            Console.Write("Write value of the first member of the sequence: ");
            int number = GetInput();

            sequence.Enqueue(number);

            for (int i = 1; i < members; i++)
            {
                int currentMember = sequence.Dequeue();
                Console.Write(" {0},", currentMember);

                sequence.Enqueue(currentMember + 1);
                sequence.Enqueue((2 * currentMember) + 1);
                sequence.Enqueue(currentMember + 2);
            }

            Console.Write('\b' + " " + '\n');
        }

        private static int GetInput()
        {
            string inputData;
            bool isNumber;
            bool isPositiveNumber;
            int number;

            while (true)
            {
                inputData = Console.ReadLine();
                isNumber = int.TryParse(inputData, out number);
                isPositiveNumber = number >= 0;

                if (isNumber && isPositiveNumber)
                {
                    number = int.Parse(inputData);
                    break;
                }
                else
                {
                    Console.WriteLine("Not correct positive number! Type again!");
                }
            }

            return number;
        }
    }
}