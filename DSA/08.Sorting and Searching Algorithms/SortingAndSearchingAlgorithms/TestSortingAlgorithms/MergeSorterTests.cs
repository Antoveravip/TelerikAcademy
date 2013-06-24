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
    public class MergeSorterTests
    {
        private static MergeSorter<int> sorter;

        [ClassInitialize]
        public static void InitilizeMergeSorter(TestContext mergeSorterData)
        {
            sorter = new MergeSorter<int>();
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
        [Timeout(5000)]
        public void SortRandomCollectionWitMoreNumbersTest()
        {
            IList<int> collection = NumbersGenerator.GetRandomNumbers(100000);

            sorter.Sort(collection);

            Assert.IsTrue(NumbersGenerator.IsSorted(collection));
        }
    }
}