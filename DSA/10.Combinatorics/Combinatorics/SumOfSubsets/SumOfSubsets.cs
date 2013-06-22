namespace SumOfSubsets
{
    using System;
    using System.Linq;

    public static class SumOfSubsets
    {
        // Inspired by videos from Algo Academy and authors solution
        public static void Main()
        {
            int sets = int.Parse(Console.ReadLine());
            for (int i = 0; i < sets; i++)
            {
                string[] binomCoefficients = Console.ReadLine().Split(' ');
                int n = int.Parse(binomCoefficients[0]);
                int k = int.Parse(binomCoefficients[1]);
                int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                long sumOfSubsets = SumOfAllSubsets(n, k, numbers);

                Console.WriteLine(sumOfSubsets);
            }
        }

        public static long CalculateBinom(int n, int k)
        {            
            long nominator = 1;
            for (int i = n - k + 1; i <= n; i++)
            {
                nominator *= i;
            }

            long denominator = 1;
            for (int i = 1; i <= k; i++)
            {
                denominator *= i;
            }

            long binomResult = nominator / denominator;

            return binomResult;
        }

        public static long CalculateTotalSum(int[] numbers)
        {
            long totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            return totalSum;
        }

        public static long SumOfAllSubsets(int n, int k, int[] numbers)
        {
            long sumSubSeq = CalculateBinom(n - 1, k) * CalculateTotalSum(numbers);

            return sumSubSeq;
        }

        // Time Limits
        /*        
        private static long sumOfSubset = 0;
        
        public static void Main()
        {
            int sets = int.Parse(Console.ReadLine());
            int n = 0, k = 0, c = 0;

            for (int i = 0; i < sets; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                n = int.Parse(input[0]);
                k = int.Parse(input[1]);
                c = n - k;
                string[] data = Console.ReadLine().Split(' ');
                int[] allSubsets = new int[c];
                int[] subset = new int[n];
                for (int j = 0; j < n; j++)
                {
                    subset[j] = int.Parse(data[j]);
                }
                sumOfSubset = 0;
                Combination(allSubsets, c, 0, 0, subset);
                Console.WriteLine(sumOfSubset);
            }
        }

        public static void Combination(int[] allSubsets, int elementsK, int index, int currentValue, int[] subset)
        {
            if (index == elementsK)
            {
                long sum = SumTheSubset(allSubsets);
                sumOfSubset += sum;
                sum = 0;
            }
            else
            {
                for (int i = currentValue; i < subset.Length; i++)
                {
                    allSubsets[index] = subset[i];
                    Combination(allSubsets, elementsK, index + 1, i + 1, subset);
                }
            }
        }

        public static long SumTheSubset(int[] currentSubset)
        {
            long sum = 0;
            for (int i = 0; i < currentSubset.Length; i++)
            {
                sum += currentSubset[i];
            }

            return sum;
        }
         * */
    }
}