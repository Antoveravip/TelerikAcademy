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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ArrayNode<K, V>
    {
        private List<KeyValuePair<K, V>> items;

        public ArrayNode()
        {
            this.items = new List<KeyValuePair<K, V>>();
        }

        public IEnumerable<V> Values
        {
            get
            {
                foreach (var pair in this.items)
                {
                    yield return pair.Value;
                }
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                if (this.items != null)
                {
                    foreach (var pair in this.items)
                    {
                        yield return pair.Key;
                    }
                }
            }
        }

        public IEnumerable<KeyValuePair<K, V>> Items
        {
            get
            {
                foreach (var pair in this.items)
                {
                    yield return pair;
                }
            }
        }

        public void Add(K key, V value)
        {
            foreach (var pair in this.items)
            {
                if (pair.Key.Equals(key))
                {
                    throw new ArgumentException("Such key already exists in collection.");
                }
            }

            this.items.Add(new KeyValuePair<K, V>(key, value));
        }

        public bool Update(K key, V value)
        {
            bool updated = false;

            foreach (var pair in this.items)
            {
                if (pair.Key.Equals(key))
                {
                    pair.Value = value;
                    updated = true;
                    break;
                }
            }

            return updated;
        }

        public bool TryGetValue(K key, out V value)
        {
            value = default(V);

            bool found = false;
            if (this.items != null)
            {
                foreach (var pair in this.items)
                {
                    if (pair.Key.Equals(key))
                    {
                        value = pair.Value;
                        found = true;
                        break;
                    }
                }
            }

            return found;
        }

        public bool Remove(K key)
        {
            bool removed = false;
            if (this.items != null)
            {
                for (int i = 0; i < this.items.Count; i++)
                {
                    if (this.items[i].Key.Equals(key))
                    {
                        this.items.RemoveAt(i);
                        removed = true;
                        break;
                    }
                }
            }

            return removed;
        }

        public void Clear()
        {
            this.items.Clear();
        }
    }
}