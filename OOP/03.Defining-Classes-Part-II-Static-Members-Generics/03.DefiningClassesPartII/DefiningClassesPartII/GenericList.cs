using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPartII
{
    public class GenericList<T>
    {
        private const int defaultCapacity = 24;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList()
            : this(defaultCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                IncreaseCapacity();
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Not correct index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        //Homework Tasks 6
        private void IncreaseCapacity()
        {
            T[] increasedArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, increasedArray, 0, elements.Length);
            elements = increasedArray;
        }

        public void Delete(T element)
        {
            int index = Array.IndexOf(elements, element);
            T[] tempArray = (T[])elements.Clone();
            elements = new T[tempArray.Length];
            Array.Copy(tempArray, index + 1, elements, index, elements.Length - index - 1);
            count--;
        }

        public int FindByValue(T element)
        {
            int index = Array.IndexOf(elements, element);
            return index; 
        }

        public void Insert(int position, T element)
        {
            if (count == elements.Length)
            {
                IncreaseCapacity();
            }
            Array.Copy(elements, position, elements, position + 1, elements.Length - position - 1);
            elements[position] = element;
            count++;
        }

        public void Clear()
        {
            int length = elements.Length;
            elements = new T[length];
        }

        public override string ToString()
        {
            string data = string.Join(",", elements.Select(x => x.ToString()).ToArray());
            return data;
        }
        //Homework Tasks 7
        public static T Min<T>(T first, T second)
        where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        //Homework Tasks 7
        public static T Max<T>(T first, T second)
        where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}