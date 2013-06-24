/* Lesson 8 - Sorting and Seraching Algorithms
 * Homework 7*
 * 
 * Unit test sorting algorithms
 * SelectionSorter.Sort()
 * Quicksorter.Sort()
 * MergeSorter.Sort()
 */

namespace TestSortingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingAndSearchingAlgorithms;

    [TestClass]
    public class SelectionSorter
    {
        private static SelectionSorter<int> sorter;

        [ClassInitialize]
        public static void InitilizeSelectionSorter(TestContext selectionSorterData)
        {
            sorter = new SelectionSorter<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortNullCollectionTest()
        {
            sorter.Sort(null);
        }

        [TestMethod]
        public void SortRandomCollectionTest()
        {
            IList<int> collection = NumbersGenerator.GetRandomNumbers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(NumbersGenerator.IsSorted(collection));
        }

        [TestMethod]
        public void SortSortedCollectionTest()
        {
            IList<int> collection = NumbersGenerator.GetSortedNumbers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(NumbersGenerator.IsSorted(collection));
        }

        [TestMethod]
        public void SortReversedCollectionTest()
        {
            IList<int> collection = NumbersGenerator.GetReversedNumbers(1000);

            sorter.Sort(collection);

            Assert.IsTrue(NumbersGenerator.IsSorted(collection));
        }

        [TestMethod]
        [Timeout(30000)]
        public void SortRandomCollectionWithMoreNumbersTest()
        {
            IList<int> collection = NumbersGenerator.GetRandomNumbers(50000);

            sorter.Sort(collection);

            Assert.IsTrue(NumbersGenerator.IsSorted(collection));
        }
    }
}