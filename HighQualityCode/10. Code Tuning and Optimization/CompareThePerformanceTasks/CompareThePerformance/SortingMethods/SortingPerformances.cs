namespace SortingMethods
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    // With help from http://itblogasen.wordpress.com/2013/05/05/testing-sorting-algorithms-performence/
    public static class SortingPerformances
    {
        internal static void DisplayPerformance(Action method, string methodName)
        {
            Console.WriteLine(methodName + " starting: ");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            method();
            timer.Stop();
            Console.WriteLine(methodName + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");
        }

        private static void InsertionSortPrformance<T>(T[] array)
            where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Insertion.Sort(cloneArray);
        }

        private static void SelectionSortPerformance<T>(T[] array)
            where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Selection.Sort(cloneArray);
        }

        private static void QuicksortPerformance<T>(T[] array)
            where T : IComparable<T>
        {
            T[] cloneArray = (T[])array.Clone();
            Quick.Sort(cloneArray, 0, cloneArray.Length - 1);
        }

        public static void ArraySorting<T>(T[] array)
            where T : IComparable<T>
        {
            DisplayPerformance(() => InsertionSortPrformance(array), "InsertionSort Performance");
            DisplayPerformance(() => SelectionSortPerformance(array), "SelectionSort Performance");
            DisplayPerformance(() => QuicksortPerformance<T>(array), "Quicksort Performance");
        }

        public static void Main()
        {
            int arrayLength = 2500;
            int[] intArray = GenerateArrays.GenerateRandomIntArray(arrayLength);
            double[] doubleArray = GenerateArrays.GenerateRandomDoubleArray(arrayLength);
            string[] stringArray = GenerateArrays.GenerateRandomStringArray(arrayLength, 100);

            Console.WriteLine("Unsorted arrays:" + Environment.NewLine + new string('-', 60));
            Console.WriteLine("Int Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<int>(intArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("Double Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<double>(doubleArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("String Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<string>(stringArray);

            Array.Sort(intArray);
            Array.Sort(doubleArray);
            Array.Sort(stringArray);

            Console.WriteLine(Environment.NewLine + new string('-', 60));
            Console.WriteLine("Sorted arrays:" + Environment.NewLine + new string('-', 60));
            Console.WriteLine("Int Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<int>(intArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("Double Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<double>(doubleArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("String Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<string>(stringArray);

            intArray = intArray.OrderByDescending(x => x).ToArray();
            doubleArray = doubleArray.OrderByDescending(x => x).ToArray();
            stringArray = stringArray.OrderByDescending(x => x).ToArray();

            Console.WriteLine(Environment.NewLine + new string('-', 60));
            Console.WriteLine("Reversed sorted arrays:" + Environment.NewLine + new string('-', 60));
            Console.WriteLine("Int Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<int>(intArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("Double Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<double>(doubleArray);
            Console.WriteLine(Environment.NewLine + new string('-', 50));
            Console.WriteLine("String Array:" + Environment.NewLine + new string('-', 50));
            ArraySorting<string>(stringArray);
        }
    }
}