namespace SortingMethods
{
    using System;

    internal static class Selection
    {
        internal static void Sort<T>(T[] array)
            where T : IComparable<T>
        {
            int minValue;
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                minValue = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j].CompareTo(array[minValue]) < 0)
                    {
                        minValue = j;
                    }
                }

                T current = array[i];
                array[i] = array[minValue];
                array[minValue] = current;
            }
        }
    }
}