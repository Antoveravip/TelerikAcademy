/* Lesson 11 - Dynamic Programming
 * Homework 1
 * 
 * Write a program based on dynamic programming to solve the "Knapsack Problem":
 * you are given N products, each has weight Wi and costs Ci and a knapsack of 
 * capacity M and you want to put inside a subset of the products with highest 
 * cost and weight ? M. The numbers N, M, Wi and Ci are integers in the range [1..500]. 
 * 
 * Example: M=10 kg, N=6, products:
 * 
 * beer – weight=3, cost=2
 * vodka – weight=8, cost=12    ==>       One optimal solution
 * cheese – weight=4, cost=5                 nuts + whiskey
 * nuts – weight=1, cost=4                   weight = 9
 * ham – weight=2, cost=3                    cost = 17
 * whiskey – weight=8, cost=13
 */

namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class Knapsack
    {
        // For this task I used information and inspiration from:
        // http://forums.academy.telerik.com/100353/dsa-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-dynamic-programming-1-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-knapsack-problem
        // http://www.youtube.com/watch?v=EH6h7WA7sDw
        // http://www.8bitavenue.com/2011/12/dynamic-programming-integer-knapsack/
        public static void Main()
        {
            // Tests data
            Item[] items = new Item[]
            {
                new Item("water", 1, 1),
                new Item("beer", 3, 2),
                new Item("wine", 5, 4),
                new Item("mastika", 6, 11),
                new Item("vodka", 8, 12),
                new Item("whiskey", 8, 13),
                new Item("coca cola", 4, 5),
                new Item("cheese", 4, 5),
                new Item("nuts", 1, 4),
                new Item("ham", 2, 3),
                new Item("sticks", 3, 5),                
            };

            /*
            Item[] items = new Item[]
            {
                new Item("beer", 3, 2),
                new Item("vodka", 8, 12),
                new Item("cheese", 4, 5),
                new Item("nuts", 1, 4),
                new Item("ham", 2, 3),
                new Item("whiskey", 8, 13),
            };
            */
            int capacity = 10;
            Stopwatch dynamicTime = new Stopwatch();

            dynamicTime.Start();
            var bestItems = KnapsackDynamic(items, capacity);
            dynamicTime.Stop();

            string bestItemsName = string.Join(" + ", bestItems.Select(r => r.Name));
            int opitmalWeigth = bestItems.Sum(r => r.Weight);
            int opitmalValue = bestItems.Sum(r => r.Value);

            Console.WriteLine("Best choice for knapsack with capacity {0}:", capacity);
            Console.WriteLine();
            Console.WriteLine("Dynamic:");
            Console.WriteLine("Items: {0}", bestItemsName);
            Console.WriteLine("Weight: {0}", opitmalWeigth);
            Console.WriteLine("Value: {0}", opitmalValue);
            Console.WriteLine();

            Stopwatch recursiveTime = new Stopwatch();
            recursiveTime.Start();
            bestItems = KnapsackRecursive(items, capacity);
            recursiveTime.Stop();

            bestItemsName = string.Join(" + ", bestItems.Select(r => r.Name));
            opitmalWeigth = bestItems.Sum(r => r.Weight);
            opitmalValue = bestItems.Sum(r => r.Value);

            Console.WriteLine("Recursive:");
            Console.WriteLine("Items: {0}", bestItemsName);
            Console.WriteLine("Weight: {0}", opitmalWeigth);
            Console.WriteLine("Value: {0}", opitmalValue);

            Console.WriteLine();
            Console.WriteLine("Time for dynamic solution:  {0}", dynamicTime.Elapsed);
            Console.WriteLine("Time for recursive solution:{0}", recursiveTime.Elapsed);
            Console.WriteLine("For {0} items - difference: {1}", items.Length, dynamicTime.Elapsed - recursiveTime.Elapsed);
        }

        public static List<Item> KnapsackDynamic(Item[] items, int capacity)
        {
            // for the recursive implementation
            if (capacity == 0)
            {
                return new List<Item>();
            }

            if (items.Length == 0)
            {
                return new List<Item>();
            }

            // row X contains the maximal value using items[0..X]
            // valuesArray[X,Y]: contains the maximal value for capacity = Y using items[0..X]

            // the max solution using items[0..X+1] for capacity Y is:
            // (let currentItem = items[X+1])
            // a) the max solution for the same capacity without currentItem, i.e. valuesArray[X,Y]
            // b) the max solution for capacity (Y - currentItem.Weight), without currentItem, + currentItem.Value
            // i.e. valuesArray[X,Y - currentItem.Weight] + currentItem.Value

            int[,] valuesArray = new int[items.Length, capacity + 1];

            // keepArray[X,Y]: if item X is included in the maximal solution for capacity Y

            int[,] keepArray = new int[items.Length, capacity + 1];

            // fill the base cases

            // capacity 0 => maximum solution is 0, with no items taken

            for (int x = 0; x <= items.Length - 1; x++)
            {
                valuesArray[x, 0] = 0;
                keepArray[x, 0] = 0;
            }

            // only 1 item => either we take it or we don't

            for (int y = 1; y <= capacity; y++)
            {
                if (items[0].Weight <= y)
                {
                    valuesArray[0, y] = items[0].Value;
                    keepArray[0, y] = 1;
                }
                else
                {
                    valuesArray[0, y] = 0;
                    keepArray[0, y] = 0;
                }
            }

            // now fill the table
            for (int x = 0; x <= items.Length - 2; x++)
            {
                for (int y = 1; y <= capacity; y++)
                {
                    var currentItem = items[x + 1];

                    if (currentItem.Weight > y)
                    {
                        // not enough space - just skip the current item
                        valuesArray[x + 1, y] = valuesArray[x, y];

                        continue;
                    }

                    // decide whether we take or drop the current item
                    int valueWhenDropping = valuesArray[x, y];
                    int valueWhenTaking = valuesArray[x, y - currentItem.Weight] + currentItem.Value;

                    // which is better?
                    if (valueWhenTaking > valueWhenDropping)
                    {
                        valuesArray[x + 1, y] = valueWhenTaking;
                        keepArray[x + 1, y] = 1;
                    }
                    else
                    {
                        valuesArray[x + 1, y] = valueWhenDropping;
                        keepArray[x + 1, y] = 0;
                    }
                }
            }

            // debug output
            // PrintMatrix(valuesArray, items.Length - 1, items);
            // PrintMatrix(keepArray, items.Length - 1, items);

            // the maximal value is in cell [items.Length - 1, capacity]
            // find the items that make up the optimal solution by walking
            // back through keepArray
            var bestItems = new List<Item>();

            {
                int remainingSpace = capacity;
                int item = items.Length - 1;

                while (item >= 0 && remainingSpace >= 0)
                {
                    // if we've taken the item
                    if (keepArray[item, remainingSpace] == 1)
                    {
                        // go up and left
                        bestItems.Add(items[item]);
                        remainingSpace -= items[item].Weight;
                        item -= 1;
                    }
                    else
                    {
                        // else go up
                        item -= 1;
                    }
                }
            }

            return bestItems;
        }

        public static List<Item> KnapsackRecursive(Item[] items, int capacity)
        {
            // base cases
            if (capacity <= 0 || items.Length == 0)
            {
                return new List<Item>();
            }

            // decide whether we take or drop the current item
            var x = items.Length - 1;
            var currentItem = items[x];

            var bestWhenDropping = KnapsackRecursive(items.Take(x).ToArray(), capacity);

            if (capacity < currentItem.Weight)
            {
                return bestWhenDropping;
            }

            var bestWhenTaking = KnapsackRecursive(items.Take(x).ToArray(), capacity - currentItem.Weight);

            bestWhenTaking.Add(currentItem);

            var valueWhenTaking = bestWhenTaking.Sum(i => i.Value);
            var valueWhenDropping = bestWhenDropping.Sum(i => i.Value);

            if (valueWhenTaking > valueWhenDropping)
            {
                return bestWhenTaking;
            }
            else
            {
                return bestWhenDropping;
            }
        }

        // hacky debugging helper
        public static void PrintMatrix(int[,] mx, int untilRow, Item[] items)
        {
            const int FOO = 17;
            // Console.Write(new string(' ', FOO));

            Console.Write("R ITEM W V |");

            for (int col = 0; col < mx.GetLength(1); ++col)
            {
                Console.Write((col + string.Empty).PadLeft(2, ' ').PadRight(3, ' '));
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', FOO + mx.GetLength(1) * 3));

            for (int row = 0; row <= untilRow; ++row)
            {
                Console.Write("{0} ", row);
                Console.Write("{0:0} ", items[row].Name.PadRight(8, ' '));
                Console.Write("{0:0} ", items[row].Weight);
                Console.Write("{0:0} |", (items[row].Value + string.Empty).PadLeft(2, ' '));

                for (int col = 0; col < mx.GetLength(1); ++col)
                {
                    Console.Write("{0:00} ", mx[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}