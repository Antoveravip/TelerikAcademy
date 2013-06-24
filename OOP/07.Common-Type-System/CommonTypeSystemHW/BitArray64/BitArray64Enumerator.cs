namespace BitArray64
{
    using System;
    using System.Collections;

    public class BitArray64Enumerator : IEnumerator
    {
        int pos = -1;
        public ulong[] values;

        public BitArray64Enumerator(ulong[] values)
        {
            this.values = values;
        }

        public bool MoveNext()
        {
            pos++;
            return (pos < values.LongLength);
        }

        public void Reset()
        {
            pos = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return values[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("Can't do requested order! The index is out of range.");
                }
            }
        }
    }
}