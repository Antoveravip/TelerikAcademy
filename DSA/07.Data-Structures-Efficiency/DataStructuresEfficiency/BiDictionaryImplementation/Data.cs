/* Lesson 7 - Data Structures Efficiency
 * Homework 3
 * 
 * Implement a class BiDictionary<K1,K2,T> that allows adding triples 
 * {key1, key2, value} and fast search by key1, key2 or by both key1 
 * and key2. Note: multiple values can be stored for given key.
 */

namespace BiDictionaryImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Data<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] data;
        private List<K> positionsKeysData;
        private int capacity;
        private int count;

        public Data()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[16];
            this.capacity = 0;
            this.positionsKeysData = new List<K>();
        }

        public List<K> Keys
        {
            get
            {
                List<K> keys = new List<K>();
                for (int i = 0; i < this.data.Length; i++)
                {
                    if (this.data[i] != null)
                    {
                        var next = this.data[i].First;
                        while (next != null)
                        {
                            keys.Add(next.Value.Key);
                            next = next.Next;
                        }
                    }
                }

                return keys;
            }

            private set 
            { 
            }
        }

        public int Count
        {
            get { return this.count; }
            private set { }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { }
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                int index = Math.Abs(key.GetHashCode() % this.data.Length);

                if (this.data[index] == null)
                {
                    throw new ArgumentException("Not found element with this key");
                }
                else
                {
                    bool isFind = false;
                    var next = this.data[index].First;
                    while (next != null)
                    {
                        if (next.Value.Key.Equals(key))
                        {
                            LinkedListNode<KeyValuePair<K, T>> node =
                                new LinkedListNode<KeyValuePair<K, T>>(new KeyValuePair<K, T>(key, value));
                            this.data[index].AddAfter(next, node);
                            this.data[index].Remove(next);
                            isFind = true;
                            break;
                        }

                        next = next.Next;
                    }

                    if (isFind == false)
                    {
                        throw new ArgumentException("Not found element with this key");
                    }
                }
            }
        }

        public void Add(K key, T value)
        {
            if (this.Capacity >= this.data.Length * 0.75)
            {
                this.ResizeContainer();
            }

            int index = Math.Abs(key.GetHashCode() % this.data.Length);

            if (this.data[index] == null)
            {
                this.capacity += 1;
                this.positionsKeysData.Add(key);
                this.data[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var next = this.data[index].First;
            while (next != null)
            {
                if (next.Value.Key.Equals(key))
                {
                    throw new ArgumentException("There is already such key!");
                }

                next = next.Next;
            }

            this.data[index].AddLast(new KeyValuePair<K, T>(key, value));
            this.count += 1;
        }

        public T Find(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.data.Length);

            if (this.data[index] == null)
            {
                throw new ArgumentException("Not found element with this key");
            }
            else
            {
                var next = this.data[index].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        return next.Value.Value;
                    }

                    next = next.Next;
                }

                throw new ArgumentException("Not found element with this key");
            }
        }

        public bool Contain(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.data.Length);

            bool isFinded = false;
            if (this.data[index] != null)
            {
                var next = this.data[index].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        isFinded = true;
                        break;
                    }

                    next = next.Next;
                }
            }

            return isFinded;
        }

        public void Remove(K key)
        {
            int index = Math.Abs(key.GetHashCode() % this.data.Length);

            if (this.data[index] == null)
            {
                throw new ArgumentException("Not found element with this key");
            }
            else
            {
                bool isFind = false;
                var next = this.data[index].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        this.data[index].Remove(next);
                        isFind = true;
                        this.count -= 1;
                    }

                    next = next.Next;
                }

                if (this.data[index].First == null)
                {
                    this.capacity -= 1;
                    this.positionsKeysData.Remove(key);
                }

                if (isFind == false)
                {
                    throw new ArgumentException("Not found element with this key");
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    var next = this.data[i].First;
                    while (next != null)
                    {
                        yield return next.Value;
                        next = next.Next;
                    }
                }
            }
        }

        private void ResizeContainer()
        {
            int length = this.data.Length * 2;
            LinkedList<KeyValuePair<K, T>>[] newContainer = new LinkedList<KeyValuePair<K, T>>[length];
            foreach (var key in this.positionsKeysData)
            {
                int oldIndex = Math.Abs(key.GetHashCode() % this.data.Length);
                int newIndex = Math.Abs(key.GetHashCode() % newContainer.Length);
                newContainer[newIndex] = this.data[oldIndex];
            }

            this.data = newContainer;
        }
    }
}