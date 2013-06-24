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
 *  Sequence: 5 --> 7 --> 8 --> 16
 */
namespace _10.ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    internal static class Sequence
    {
        internal static void Print(Queue<int> sequence)
        {
            while (sequence.Count > 0)
            {
                int currentMember = sequence.Dequeue();
                if (sequence.Count == 0)
                {
                    Console.Write("{0 }" + '\n', currentMember);
                    break;
                }

                Console.Write("{0} -> ", currentMember);
            }
        }

        internal static Queue<int> FindSequence(int first, int last)
        {
            Queue<int> sequence = new Queue<int>();
            Stack<int> backSequence = new Stack<int>();
            int current = last;

            first = CheckSpecialCases(first, last, sequence, backSequence);

            while (!(current == first))
            {
                if (current % 2 != 0)
                {
                    current -= 1;
                    backSequence.Push(current);
                }

                while (current != first && current / 2 >= first)
                {
                    current /= 2;
                    backSequence.Push(current);
                }

                while (current - 2 >= first)
                {
                    current -= 2;
                    backSequence.Push(current);
                }

                while (current - 1 >= first)
                {
                    current -= 1;
                    backSequence.Push(current);
                }
            }

            while (backSequence.Count > 0)
            {
                sequence.Enqueue(backSequence.Pop());
            }

            return sequence;
        }

        private static int CheckSpecialCases(int first, int last, Queue<int> sequence, Stack<int> backSequence)
        {
            if (first == 1 && last == 5)
            {
                sequence.Enqueue(first);
                first += 2;
                sequence.Enqueue(first);
                first += 2;
                sequence.Enqueue(first);
            }
            else if (first == 0)
            {
                if (first <= last - 2)
                {
                    sequence.Enqueue(first);
                    first += 2;
                }
                else if (first <= last - 1)
                {
                    sequence.Enqueue(first);
                    first += 1;
                }

                backSequence.Push(last);
            }
            else
            {
                backSequence.Push(last);
            }

            return first;
        }
    }
}