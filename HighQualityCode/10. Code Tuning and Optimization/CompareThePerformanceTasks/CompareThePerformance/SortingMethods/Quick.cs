namespace SortingMethods
{
    using System;

    internal static class Quick
    {
        internal static void Sort<T>(T[] array, int leftSide, int rightSide)
            where T : IComparable<T>
        {
            int left = leftSide;
            int right = rightSide;
            int center = (leftSide + rightSide) / 2;
            T middle = array[center];

            while (left <= right)
            {
                while (array[left].CompareTo(middle) < 0)
                {
                    left++;
                }

                while (middle.CompareTo(array[right]) < 0)
                {
                    right--;
                }

                if (left <= right)
                {
                    T curremt = array[left];
                    array[left] = array[right];
                    array[right] = curremt;

                    left++;
                    right--;
                }
            }

            if (leftSide < right)
            {
                Sort(array, leftSide, right);
            }

            if (left < rightSide)
            {
                Sort(array, left, rightSide);
            }
        }
    }
}