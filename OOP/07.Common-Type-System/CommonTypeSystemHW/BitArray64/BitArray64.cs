/* 07.Common-Type-System
 * 
 * Homework task 5:
 * 
 * Define a class BitArray64 to hold 64 bit values inside an ulong value.
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 * 
 */

namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        ulong[] values;
        int pos;

        public BitArray64(int length)
        {
            values = new ulong[length];
            pos = 0;
        }

        public void Add(ulong value)
        {
            if (pos < values.Length)
            {
                values[pos] = value;
                pos++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int Length
        {
            get { return values.Length; }
        }

        public ulong this[int i]
        {
            get { return values[i]; }
            set { values[i] = value; }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            BitArray64 array = (BitArray64)obj;
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                ulong hash = 19;
                foreach (var item in values)
                {
                    hash += (ulong)item.GetHashCode();
                    hash *= 23;
                }
                hash += (ulong)values.Length.GetHashCode();
                return (int)hash;
            }
        }

        public BitArray64Enumerator GetEnumerator()
        {
            return new BitArray64Enumerator(values);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }
    }
}