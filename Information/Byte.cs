using System;
using System.Collections.Generic;

namespace Information
{
    public class Byte
    {
        public static readonly Byte ZERO = new Byte((byte)0);

        public const int SIZE = 8;
        private Bit[] bits;

        public Byte()
        {
            bits = new Bit[SIZE];

            for (int i = 0; i < SIZE; i++)
                bits[i] = Bit.ZERO;
        }

        public Byte(byte aByte)
        {
            bits = new Bit[SIZE];

            for (int i = 0; i < SIZE; i++)
                bits[i] = Processing.BitExtractor(aByte, i);
        }

        public Bit Get(int index) 
        {
            CheckIndex(index);

            return bits[index]; 
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= SIZE)
                throw new Exception("Index out of BYTE range.");
        }

        private void CheckBit(int bit)
        {
            if (!(bit == 1 || bit == 0))
                throw new Exception("Set bit value is invalid.");
        }

        public void Set(int index, int bit)
        {
            CheckIndex(index);
            CheckBit(bit);
            bits[index] = bit == 1 ? Bit.ONE : Bit.ZERO;
        }

        public void FlipBit(int index)
        {
            CheckIndex(index);
            bits[index] = bits[index].Equals(Bit.ZERO) ?
                bits[index] = Bit.ONE :
                bits[index] = Bit.ZERO;
        }

        public bool Equals(Byte other)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (!bits[i].Equals(other.bits[i]))
                    return false;
            }

            return true;
        }
    }

    public class ByteComparer : IEqualityComparer<Byte>
    {
        public bool Equals(Byte x, Byte y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Byte obj)
        {
            throw new NotImplementedException();
        }
    }
}
