using System;

namespace RangeException
{
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        // --- FIELDS --- //
        private T start;
        private T end;

        // --- PROPERTIES --- //
        public T Start { get { return start; } }
        public T End { get { return end; } }

        // --- CONSTRUCTORS --- //
        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end, Exception causeException)
            : base(message, causeException)
        {
            this.start = start;
            this.end = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }

        // --- METHODS --- //
        public override string Message
        {
            get
            {
                string result = string.Format("This value is out of the range {0} - {1}", this.start, this.end);
                return result;
            }
        }
    }
}