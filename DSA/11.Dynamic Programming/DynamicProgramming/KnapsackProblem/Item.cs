/* Lesson 11 - Dynamic Programming
 * Homework 1
 * 
 * Write a program based on dynamic programming to solve the "Knapsack Problem":
 * you are given N products, each has weight Wi and costs Ci and a knapsack of 
 * capacity M and you want to put inside a subset of the products with highest 
 * cost and weight ≤ M. The numbers N, M, Wi and Ci are integers in the range [1..500]. 
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
    public struct Item
    {
        public Item(string name, int weight, int value)
            : this()
        {
            this.Name = name;
            this.Weight = weight;
            this.Value = value;
        }

        public string Name { get; private set; }

        public int Weight { get; private set; }

        public int Value { get; private set; }
    }
}