/* Lesson 5 - Dictionaries Hash Tables And Sets
 * Homework 4
 * 
 * Implement the data structure "hash table" in a class HashTable<K,T>.
 * Keep the data in array of lists of key-value pairs 
 * (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When 
 * the hash table load runs over 75%, perform resizing to 2 times larger capacity.
 * Implement the following methods and properties: Add(key, value), Find(key)-->value,
 * Remove( key), Count, Clear(), this[], Keys. Try to make the hash table to support
 * iterating over its elements with foreach.
 */

namespace _04.DataStructureHashTable
{
    using System;

    public class CheckImplementation
    {
        public static void Main()
        {
            HashTable<string, string> hashTable = new HashTable<string, string>();
            hashTable.Add("1", "abc");
            hashTable.Add("2", "qwe");
            hashTable.Add("3", "rty");
            hashTable.Add("4", "1q2w3e");
            hashTable.Add("5", "asasas");
            hashTable.Add("6", "babababa");
            hashTable.Add("7", "dadadada");

            Console.WriteLine(hashTable.Find("4"));
            Console.WriteLine("Count: {0}", hashTable.Count);

            hashTable.Remove("1");
            Console.WriteLine("Count: {0}", hashTable.Count);
            Console.WriteLine(hashTable["3"]);

            Console.WriteLine("\nKeys: ");
            foreach (var item in hashTable.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIteration with foreach:");
            foreach (var item in hashTable)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}