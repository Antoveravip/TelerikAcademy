/* Lesson 5 - Dictionaries Hash Tables And Sets
 * Homework 5
 * 
 * Implement the data structure "set" in a class HashedSet<T>
 * using your class HashTable<K,T> to hold the elements.
 * Implement all standard set operations like Add(T), Find(T),
 * Remove(T), Count, Clear(), union and intersect.
 */
namespace _05.DataStructureSet
{
    using System;

    public static class CheckImplementation
    {
        public static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add("aaaaa");
            hashSet.Add("vvvv");
            hashSet.Add("eee");
            hashSet.Add("ttttttt");

            foreach (var item in hashSet.Items)
            {
                Console.WriteLine(item);
            }

            hashSet.Remove("eee");
            Console.WriteLine("\nCount after remove: {0}", hashSet.Count);

            Console.WriteLine();
            Console.WriteLine(hashSet.Find("ttttttt"));

            HashSet<string> newHashSet = new HashSet<string>();
            newHashSet.Add("azaz");
            newHashSet.Add("tqtq");
            newHashSet.Add("aaaa");
            newHashSet.Add("inow");

            Console.WriteLine("\nUnion: ");
            HashSet<string> union = hashSet.Union(newHashSet);
            foreach (var item in union.Items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIntersection: ");
            HashSet<string> intersection = hashSet.Intersect(newHashSet);
            foreach (var item in intersection.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}