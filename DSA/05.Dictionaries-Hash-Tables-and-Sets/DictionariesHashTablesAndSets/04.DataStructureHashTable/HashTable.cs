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
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>, IEnumerable
    {
        private const double FillFactor = 0.75d;
        private int maxItemsAtCurrentSize; 
        private int count;
        private HashTableArray<K, V> array;

        public HashTable()
            : this(16)
        {
        }

        public HashTable(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentException("Invalid initial capacity.");
            }

            this.array = new HashTableArray<K, V>(initialCapacity);
            this.maxItemsAtCurrentSize = (int)(initialCapacity * FillFactor) + 1;
        }

        public IEnumerable<K> Keys
        {
            get
            {
                return this.array.Keys;
            }
        }

        public IEnumerable<V> Values
        {
            get
            {
                return this.array.Values;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public V this[K key]
        {
            get
            {
                V value;
                if (!this.array.TryGetValue(key, out value))
                {
                    throw new ArgumentException("Invalid key");
                }

                return value;
            }

            set
            {
                this.array.Update(key, value);
            }
        }

        public void Add(K key, V value)
        {
            if (this.count >= this.maxItemsAtCurrentSize)
            {
                this.GrowArray();
            }

            this.array.Add(key, value);
            this.count++;
        }

        public bool Remove(K key)
        {
            if (this.array.Remove(key))
            {
                this.count--;
                return true;
            }

            return false;
        }

        public V Find(K key)
        {
            return this.array[key];
        }

        public bool TryGetValue(K key, out V value)
        {
            bool hasValue = this.array.TryGetValue(key, out value);
            return hasValue;
        }

        public bool ContainsKey(K key)
        {
            V value;
            return this.array.TryGetValue(key, out value);
        }

        public bool ContainsValue(V value)
        {
            foreach (var foundValue in this.array.Values)
            {
                if (value.Equals(foundValue))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            return this.array.Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Clear()
        {
            this.array.Clear();
            this.count = 0;
        }       

        private void GrowArray()
        {
            HashTableArray<K, V> largerArray = new HashTableArray<K, V>(this.array.Capacity * 2);

            foreach (var node in this.array.Items)
            {
                if (node != null)
                {
                    largerArray.Add(node.Key, node.Value);
                }
            }

            this.array = largerArray;
            this.maxItemsAtCurrentSize = (int)(this.array.Capacity * FillFactor) + 1;
        }
    }
}