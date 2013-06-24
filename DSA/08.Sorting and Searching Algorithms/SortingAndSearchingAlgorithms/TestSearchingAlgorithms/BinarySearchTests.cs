/* Lesson 8 - Sorting and Seraching Algorithms
 * Homework 8*
 * 
 * Unit test searching algorithms
 * SortableCollection.LinearSearch()
 * SortableCollection.BinarySearch()
 */

namespace TestSearchingAlgorithms
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingAndSearchingAlgorithms;

    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void SearchNonExistingItemTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(256);

            Assert.IsFalse(isFound);
        }

        [TestMethod]
        public void SearchExistingItemInTheBeginingTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(22);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void SearchExistingItemInTheEndTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(3);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void SearchExistingItemInTheMiddleTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(-8436545);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void SearchExistingItemInFirstHalfTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(156);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void SearchExistingItemInSecondHalfTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(8);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void SearchExistingItemWithTwoPresentsTest()
        {
            int[] items = new int[]
            {
                22, 1060, 982123878, 12537, 45842, 244578, 24242, 
                156, 1225, -1825, -888871, 16, 16, -5, -8436545,
                564583, -98287, -454543, 88735, -829356289, 8,
                -5872253, -11, -7852, 89962, 1, 88723475, 1157, 3
            };
            SortableCollection<int> collection = new SortableCollection<int>(items);

            bool isFound = collection.BinarySearch(16);

            Assert.IsTrue(isFound);
        }
    }
}