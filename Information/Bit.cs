using System.Collections.Generic;

namespace Information
{
    public class Bit
    {
        public static readonly Bit ZERO = new Bit(0);
        public static readonly Bit ONE = new Bit(1);

        public Bit(int bit) { Value = bit == 1; }
        public bool Value { get; set; }
        public bool Equals(Bit other) { return Value == other.Value; }
    }

    public class BitComparer : IEqualityComparer<Bit>
    {
        public bool Equals(Bit x, Bit y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Bit obj)
        {
            throw new System.NotImplementedException();
        }
    }
}

