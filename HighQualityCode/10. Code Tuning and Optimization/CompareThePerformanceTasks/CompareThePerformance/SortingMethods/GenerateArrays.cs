namespace SortingMethods
{
    using System;

    internal static class GenerateArrays
    {
        private static Random randomNumbers = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        internal static int[] GenerateRandomIntArray(int arrLength)
        {
            int[] value = new int[arrLength];
            int length = value.Length;

            for (int i = 0; i < length; i++)
            {
                value[i] = randomNumbers.Next(int.MinValue, int.MaxValue);
            }

            return value;
        }

        internal static double[] GenerateRandomDoubleArray(int arrLength)
        {
            double[] value = new double[arrLength];
            int length = value.Length;

            for (int i = 0; i < length; i++)
            {
                int sign = randomNumbers.Next(0, 2);

                if (sign == 0)
                {
                    value[i] = randomNumbers.NextDouble() * double.MaxValue;
                }
                else
                {
                    value[i] = randomNumbers.NextDouble() * double.MinValue;
                }
            }

            return value;
        }

        internal static string[] GenerateRandomStringArray(int arrLength, int stringMaxSize)
        {
            string[] value = new string[arrLength];
            int length = value.Length;

            for (int i = 0; i < length; i++)
            {
                value[i] = GenerateRandomString(randomNumbers.Next(1, stringMaxSize + 1));
            }

            return value;
        }

        internal static string GenerateRandomString(int size)
        {
            char[] randomString = new char[size];
            int length = Chars.Length;

            for (int i = 0; i < size; i++)
            {
                randomString[i] = Chars[randomNumbers.Next(length)];
            }

            return new string(randomString);
        }
    }
}