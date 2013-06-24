/* Lesson 6 - Advanced Data Structures
 * Homework 1
 * 
 * Implement a class PriorityQueue<T> based 
 * on the data structure "binary heap".
 */

namespace ImplementationOfPriorityQueue
{
    using System;

    public static class CheckImplementation
    {
        public static void Main()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            priorityQueue.Enqueue(11);
            priorityQueue.Enqueue(22);
            priorityQueue.Enqueue(16);
            priorityQueue.Enqueue(7);
            priorityQueue.Enqueue(3);

            Console.WriteLine("Peek at biggest element: {0} ", priorityQueue.Peek());
            priorityQueue.Dequeue();

            Console.WriteLine("Peek after dequeue: {0}", priorityQueue.Peek());

            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(33);
            Console.WriteLine("Biggest element after enqueue: {0} ", priorityQueue.Peek());
        }
    }
}