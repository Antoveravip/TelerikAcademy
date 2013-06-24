using System;
using System.Collections.Generic;

namespace Timer
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> data) where T : IComparable
        {
            dynamic sum = 0;
            foreach (var member in data)
            {
                sum += (dynamic)member;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> data) where T : IComparable
        {
            dynamic product = 0;
            foreach (var member in data)
            {
                product *= (dynamic)member;
                if (product == 0) { break; }
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> data) where T : IComparable
        {
            dynamic min = long.MaxValue;
            foreach (var member in data)
            {
                if (member < min)
                {
                    min = member;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> data) where T : IComparable
        {
            dynamic max = long.MinValue;
            foreach (var member in data)
            {
                if (member > max)
                {
                    max = member;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> data) where T : IComparable
        {
            dynamic sum = 0, average = 0;
            long count = 0;
            foreach (var member in data)
            {
                sum += member;
                count++;
            }
            if (count == 0)
            {
                throw new NullReferenceException("The collection is empty.");
            }
            else
            {
                average = sum / count;
            }
            return average;
        }
    }
}