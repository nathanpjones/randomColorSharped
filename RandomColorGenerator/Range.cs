using System;
using System.Diagnostics;

namespace RandomColorGenerator
{
    /// <summary>
    /// Represents a range using an upper and lower value.
    /// </summary>
    [DebuggerDisplay(@"\{{Lower},{Upper}\}")]
    internal class Range
    {
        public int Lower { get; set; }
        public int Upper { get; set; }

        public Range()
        { }
        public Range(int lower, int upper)
        {
            Lower = lower;
            Upper = upper;
        }

        /// <summary>
        /// Gets the lower range for an index of 0 and the upper for an index of 1.
        /// </summary>
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return Lower;
                    case 1: return Upper;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: Lower = value; break;
                    case 1: Upper = value; break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        internal static Range ToRange(int[] range)
        {
            if (range == null) return null;
            Debug.Assert(range.Length == 2);
            return new Range(range[0], range[1]);
        }
    }
}