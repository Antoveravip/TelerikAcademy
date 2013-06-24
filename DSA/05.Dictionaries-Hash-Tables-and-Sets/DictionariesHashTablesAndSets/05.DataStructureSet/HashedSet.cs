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
    using System.Collections.Generic;
    using System.Linq;
    using _04.DataStructureHashTable;

    public class HashSet<T>
    {
        private HashTable<int, T> hashTable;

        public HashSet()
        {
            this.hashTable = new HashTable<int, T>();
        }
        
        public int Count
        {
            get
            {
                return this.hashTable.Count;
            }
        }

        public IEnumerable<T> Items
        {
            get
            {
                return this.hashTable.Values;
            }
        }

        public T this[T index]
        {
            get
            {
                return this.hashTable[index.GetHashCode()];
            }

            set
            {
                this.hashTable[index.GetHashCode()] = value;
            }
        }

        public void Add(T value)
        {
            this.hashTable.Add(value.GetHashCode(), value);
        }

        public T Find(T value)
        {
            T data = this.hashTable.Find(value.GetHashCode());
            return data;
        }

        public bool Remove(T value)
        {
            bool hasRemoved = this.hashTable.Remove(value.GetHashCode());
            return hasRemoved;
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public HashSet<T> Union(HashSet<T> otherSet)
        {
            IEnumerable<T> union = this.Items.Union(otherSet.Items);
            HashSet<T> newSet = new HashSet<T>();

            foreach (var item in union)
            {
                newSet.Add(item);
            }

            return newSet;
        }

        public HashSet<T> Intersect(HashSet<T> otherSet)
        {
            IEnumerable<T> intersect = this.Items.Intersect(otherSet.Items);
            HashSet<T> newSet = new HashSet<T>();

            foreach (var item in intersect)
            {
                newSet.Add(item);
            }

            return newSet;
        }        
    }
}