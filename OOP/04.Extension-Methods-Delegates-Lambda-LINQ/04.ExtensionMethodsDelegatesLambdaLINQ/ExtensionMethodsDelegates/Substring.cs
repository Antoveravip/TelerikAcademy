using System;
using System.Text;

namespace Timer
{
    public static class Substring
    {
        public static StringBuilder Substrings(this StringBuilder text, int startIndex)
        {
            if (text.Length >= startIndex)
            {
                throw new IndexOutOfRangeException("Starting index is larger than the length of inputed string.");
            }
            StringBuilder data = new StringBuilder();
            data.Append(text.ToString().Substring(startIndex));
            return data;
        }

        public static StringBuilder Substrings(this StringBuilder text, int startIndex, int length)
        {
            if (text.Length >= startIndex)
            {
                throw new IndexOutOfRangeException("Starting index is larger than the length of inputed string.");
            }

            if (text.Length >= startIndex + length)
            {
                throw new IndexOutOfRangeException("The length of this substring exceeds the length of the StringBuilder after the start index.");
            }
            StringBuilder data = new StringBuilder();
            data.Append(text.ToString().Substring(startIndex, length));
            return data;
        }
    }
}     