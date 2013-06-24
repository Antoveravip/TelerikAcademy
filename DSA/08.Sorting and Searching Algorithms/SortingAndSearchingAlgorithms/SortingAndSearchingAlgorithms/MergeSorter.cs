/* Lesson 8 - Sorting and Seraching Algorithms
 * Homework 3
 * 
 * Implement MergeSorter.Sort() method using merge sort algorithm
 */

namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection can't be null!");
            }

            IList<T> sortedCollection = this.MergeSort(collection);

            collection.Clear();
            foreach (T item in sortedCollection)
            {
                collection.Add(item);
            }
        }

        private IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int middleElement = collection.Count / 2;

            IList<T> leftPart = new List<T>();
            for (int index = 0; index < middleElement; index++)
            {
                leftPart.Add(collection[index]);
            }

            IList<T> rightPart = new List<T>();
            for (int index = middleElement; index < collection.Count; index++)
            {
                rightPart.Add(collection[index]);
            }

            leftPart = this.MergeSort(leftPart);
            rightPart = this.MergeSort(rightPart);

            return this.Merge(leftPart, rightPart);
        }

        private IList<T> Merge(IList<T> leftPart, IList<T> rightPart)
        {
            IList<T> mergedCollection = new List<T>();
            while (leftPart.Count > 0 || rightPart.Count > 0)
            {
                if (leftPart.Count > 0 && rightPart.Count > 0)
                {
                    if (leftPart[0].CompareTo(rightPart[0]) <= 0)
                    {
                        mergedCollection.Add(leftPart[0]);
                        leftPart.RemoveAt(0);
                    }
                    else
                    {
                        mergedCollection.Add(rightPart[0]);
                        rightPart.RemoveAt(0);
                    }
                }
                else if (rightPart.Count > 0)
                {
                    mergedCollection.Add(rightPart[0]);
                    rightPart.RemoveAt(0);
                }
                else if (leftPart.Count > 0)
                {
                    mergedCollection.Add(leftPart[0]);
                    leftPart.RemoveAt(0);
                }
            }

            return mergedCollection;
        }
    }
}