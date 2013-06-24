/* Lesson 3 - Linear Data Structures
 * Homework 4
 * 
 * Write a method that finds the longest subsequence of equal numbers 
 * in given List<int> and returns the result as new List<int>.
 * Write a program to test whether the method works correctly.
 */

namespace LinearDataStructuresTest
{
    using System;
    using System.Collections.Generic;
    using _04.FindLongestSubsequenceFromEqualNumbers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindLongestSubsequenceFromEqualNumbersTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ListFindLongestSubsequenceWithNullOrEmptyList()
        {
            List<int> numbers = new List<int>() { };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithOneValue()
        {
            List<int> numbers = new List<int>() { 1 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithOnlyOneNumberSequence()
        {
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 1 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1, 1, 1, 1, 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithNegativeNumbers()
        {
            List<int> numbers = new List<int>() { -1, -1, 0, -2, -2 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { -1, -1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithTwoNumbersList()
        {
            List<int> numbers = new List<int>() { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithNoLongestSubsequence()
        {
            List<int> numbers = new List<int>() { 1, 8, 9, 7, 2, 3, 5, 4, 10, 0, -1, -2 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithTwoLongestSubsequence()
        {
            List<int> numbers = new List<int>() { 1, 1, 1, 2, 2, 2, 8, 8, 7, 7, -1, -1 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1, 1, 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        public void ListFindLongestSubsequenceWithThreeLongestSubsequence()
        {
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };
            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            List<int> expected = new List<int>() { 1, 1, 1, 1 };

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");
        }

        [TestMethod]
        [Timeout(5000)]
        public void TestAddAndSearchPerformance()
        {
            int oneAddCount = 1000000;
            int twoAddCount = 1000001;

            List<int> numbers = new List<int>();
            List<int> expected = new List<int>();

            for (int i = 0; i < oneAddCount; i++)
            {
                numbers.Add(1);
            }

            for (int i = 0; i < twoAddCount; i++)
            {
                numbers.Add(2);
                expected.Add(2);
            }

            List<int> longestSubsequence = new List<int>();
            longestSubsequence = ListFind.LongestSubsequence(numbers);

            Assert.AreEqual(expected.Count, longestSubsequence.Count, "The length of this List is not correct");
            CollectionAssert.AreEqual(expected, longestSubsequence, "The subsequence is not correct!");            
        }
    }
}