using System;
using System.Diagnostics;
using System.Linq;

public static class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        // Here I thing is better way with one if check that throw exeption! Leave it that way for the homeworks task!
        Debug.Assert(arr != null && arr.Length >= 0, "The array is not initialized!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // If array is not sorted - thats show that for cicle have some bug.
        Debug.Assert(IsArraySorted(arr), "The array is not correctly sorted!");
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length >= 0, "The array is not initialized!");
        Debug.Assert(value != null, "Searched value is null!");

        // In computer science, a binary search or half-interval search algorithm finds
        // the position of a specified value (the input "key") within a sorted array.
        Debug.Assert(IsArraySorted(arr), "The array is not correctly sorted!");

        int binarySearchResult = BinarySearch(arr, value, 0, arr.Length - 1);

        Debug.Assert(FindValue(arr, value, 0, arr.Length - 1) == binarySearchResult, "The founded index of the value is not correct!");

        return binarySearchResult;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        // Here too is better way with one if check that throw exeptions!
        // We can skip first assert -this is private method and is called from public method where this assert was checked!
        Debug.Assert(arr != null && arr.Length >= 0, "The array is not initialized!");
        Debug.Assert(startIndex <= endIndex, "The entered startIndex is bigger than entered endIndex!");
        Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "Start index is out of the array range!");
        Debug.Assert(0 <= endIndex && endIndex <= arr.Length - 1, "End index is out of the array range!");

        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(IsMinElementIndex<T>(arr, startIndex, endIndex), "The minimal element index is not correct!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        // We can skip first three asserts - this is private method and is called from public method where this assert was checked!
        Debug.Assert(arr != null && arr.Length >= 0, "The array is not initialized!");
        Debug.Assert(value != null, "Searched value is null!");
        Debug.Assert(IsArraySorted(arr), "The array is not correctly sorted!");
        
        Debug.Assert(startIndex <= endIndex, "The entered startIndex is bigger than entered endIndex!");
        Debug.Assert(0 <= startIndex && startIndex <= arr.Length - 1, "Start index is out of the array range!");
        Debug.Assert(0 <= endIndex && endIndex <= arr.Length - 1, "End index is out of the array range!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the left half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    // Created for helping Debug.Assert checks!
    private static bool IsArraySorted<T>(T[] arr) where T : IComparable<T>
    {
        bool isSorted = true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) > 0)
            {
                isSorted = false;
            }
        }

        return isSorted;
    }

    // Created for helping Debug.Assert checks!
    private static bool IsMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        bool isMinElementIndex = true;
        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[minElementIndex].CompareTo(arr[minElementIndex]) > 0)
            {
                isMinElementIndex = false;
            }
        }

        return isMinElementIndex;
    }

    // Created for helping Debug.Assert checks!
    private static int FindValue<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        int output = -1;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(value) == 0)
            {
                output = i;
            }
        }

        return output;
    }

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}