namespace SortingMethods
{
    using System;

    internal static class Insertion
    {
        internal static void Sort<T>(T[] array)
           where T : IComparable<T>
        {
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                T value = array[i];
                int j = i - 1;
                bool done = false;

                do
                {
                    if (array[j].CompareTo(value) > 0)
                    {
                        array[j + 1] = array[j];
                        j--;

                        if (j < 0)
                        {
                            done = true;
                        }
                    }
                    else
                    {
                        done = true;
                    }
                }
                while (!done);

                array[j + 1] = value;
            }
        }
    }
}