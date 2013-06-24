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
    using System.Collections.Generic;

    internal class HashTableArray<K, V>
    {
        private ArrayNode<K, V>[] array;

        public HashTableArray(int capacity)
        {
            this.array = new ArrayNode<K, V>[capacity];
        }

        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public IEnumerable<KeyValuePair<K, V>> Elements
        {
            get
            {
                foreach (var node in this.array)
                {
                    if (node == null)
                    {
                        continue;
                    }

                    foreach (var entry in node.Items)
                    {
                        if (entry == null)
                        {
                            continue;
                        }

                        yield return entry;
                    }
                }
            }
        }

        public IEnumerable<V> Values
        {
            get
            {
                foreach (var node in this.array)
                {
                    if (node != null)
                    {
                        foreach (var value in node.Values)
                        {
                            yield return value;
                        }
                    }
                }
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                foreach (var node in this.array)
                {
                    if (node != null)
                    {
                        foreach (var key in node.Keys)
                        {
                            yield return key;
                        }
                    }
                }
            }
        }

        public IEnumerable<KeyValuePair<K, V>> Items
        {
            get
            {
                foreach (var node in this.array)
                {
                    if (node != null)
                    {
                        foreach (var pair in node.Items)
                        {
                            yield return pair;
                        }
                    }
                }
            }
        }

        public V this[K key]
        {
            get
            {
                IEnumerable<KeyValuePair<K, V>> found = this.array[this.GetIndex(key)].Items;
                foreach (var item in found)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }

                throw new ArgumentException("Invalid key");
            }
        }

        public void Add(K key, V value)
        {
            if (key == null || value == null)
            {
                return;
            }

            int index = this.GetIndex(key);
            if (this.array[index] == null)
            {
                this.array[index] = new ArrayNode<K, V>();
            }

            this.array[index].Add(key, value);
        }

        public void Update(K key, V value)
        {
            int index = this.GetIndex(key);
            if (this.array[index] == null)
            {
                throw new ArgumentException("Element does not exist");
            }

            this.array[index].Update(key, value);
        }

        public bool Remove(K key)
        {
            return this.array[this.GetIndex(key)].Remove(key);
        }

        public bool TryGetValue(K key, out V value)
        {
            int index = this.GetIndex(key);
            if (this.array[index] == null)
            {
                value = default(V);
                return false;
            }

            return this.array[index].TryGetValue(key, out value);
        }        

        public void Clear()
        {
            foreach (var node in this.array)
            {
                if (node != null)
                {
                    node.Clear();
                }
            }
        }

        private int GetIndex(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.Capacity);
            return index;
        }
    }
}