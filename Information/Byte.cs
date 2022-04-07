using System;

namespace Information
{
    public class Byte
    {
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

        public Bit Get(int index) { return bits[index]; }

        public void Set(int bit, int index)
        {
            if (index < 0 || index >= SIZE)
                throw new Exception("Index out of BYTE range.");

            if (!(bit == 1 || bit == 0))
                throw new Exception("Set bit value is invalid.");

            bits[index] = bit == 1 ? Bit.ONE : Bit.ZERO;
        }
    }
}
