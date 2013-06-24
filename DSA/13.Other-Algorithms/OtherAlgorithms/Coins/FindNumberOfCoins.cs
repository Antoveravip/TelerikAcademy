/* Lesson 13 - Other Algorithms
 * Homework 1
 * 
 * You are given a set of infinite number of coins (1, 2 and 5) and end value – N.
 * Write an algorithm that gives the number of coins needed so that the sum of the
 * coins equals N.
 * Example:
 * N = 33 => 6 coins x 5 + 1 coin x 2 + 1 coin x 1
 */

namespace Coins
{
    using System;

    public static class FindNumberOfCoins
    {
        private static long[] coinsValue = { 1, 2, 5 };
        private static long[] coinsNumber = { 0, 0, 0 };

        public static void Main()
        {
            Console.Write("Type amount of money: ");
            long sum = GetInput();
            FindTotalCoins(sum);
            Console.WriteLine("The minimal numbers of coins /1, 2, 5/ that represent this value are:");
            Print(sum);
        }

        public static void FindTotalCoins(long sum)
        {
            if (sum != 0)
            {
                for (int index = coinsNumber.Length - 1; index >= 0 & sum > 0; index--)
                {
                    coinsNumber[index] = sum / coinsValue[index];
                    sum -= coinsNumber[index] * coinsValue[index];
                }
            }
        }

        private static long GetInput()
        {
            string inputData;
            bool isNumber;
            bool isPositiveNumber;
            long number;

            while (true)
            {
                inputData = Console.ReadLine();
                isNumber = long.TryParse(inputData, out number);
                isPositiveNumber = number >= 0;

                if (isNumber && isPositiveNumber)
                {
                    number = long.Parse(inputData);
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

        private static void Print(long sum)
        {
            if (sum != 0)
            {
                for (int i = coinsNumber.Length - 1; i >= 0; i--)
                {
                    if (coinsNumber[i] > 0)
                    {
                        Console.WriteLine("{0} coins X {1}", coinsNumber[i], coinsValue[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("0 coins!");
            }

            Console.WriteLine();
        }
    }
}