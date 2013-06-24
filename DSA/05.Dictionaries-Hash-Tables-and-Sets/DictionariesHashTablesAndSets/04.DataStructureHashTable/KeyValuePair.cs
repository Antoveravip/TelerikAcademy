﻿/* Lesson 5 - Dictionaries Hash Tables And Sets
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
    public class KeyValuePair<K, V>
    {
        public KeyValuePair()
        {
        }

        public KeyValuePair(K key, V value)
        {
            this.Key = key;
            this.Value = value;
        }

        public K Key
        {
            get;
            private set;
        }

        public V Value
        {
            get;
            set;
        }
    }
}