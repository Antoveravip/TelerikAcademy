namespace TestSortingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public static class NumbersGenerator
    {
        private static Random randomValues = new Random();

        public static IList<int> GetRandomNumbers(int numbers)
        {
            IList<int> randomNumbers = new List<int>(numbers);

            for (int i = 0; i < numbers; i++)
            {
                randomNumbers.Add(randomValues.Next());
            }

            return randomNumbers;
        }

        public static IList<int> GetSortedNumbers(int numbers)
        {
            IList<int> sortedNumbers = new List<int>(numbers);

            for (int i = 0; i < numbers; i++)
            {
                sortedNumbers.Add(i);
            }

            return sortedNumbers;
        }

        public static IList<int> GetReversedNumbers(int numbers)
        {
            IList<int> reversedNumbers = new List<int>(numbers);

            for (int i = numbers; i > 0; i--)
            {
                reversedNumbers.Add(i);
            }

            return reversedNumbers;
        }

        public static bool IsSorted(IList<int> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (collection[i] > collection[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}