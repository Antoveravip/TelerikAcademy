/* Lesson 3 - Linear Data Structures
 * Homework 10*
 * 
 *  We are given numbers N and M and the following operations:
 *  a) N = N+1
 *  b) N = N+2
 *  c) N = N*2
 *  Write a program that finds the shortest sequence of operations 
 *  from the list above that starts from N and finishes in M. 
 *  Hint: use a queue.
 *  Example: N = 5, M = 16
 *  Sequence: 5 --> 7  8  16
 */
namespace _10.ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    public static class ShortestSequence
    {
        public static void Main()
        {
            Console.Write("Type value for first number - N = ");
            int first = GetInput();

            Console.Write("Type velue for second number / must be greater than N / - M = ");
            int last = GetInput();

            Queue<int> sequence = Sequence.FindSequence(first, last);
            Sequence.Print(sequence);
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
                else if (!isPositiveNumber)
                {
                    Console.WriteLine("Not correct positive number! Type again!");
                }
                else
                {
                    Console.WriteLine("Not correct number format! Type again!");
                }
            }

            return number;
        }
    }
}
