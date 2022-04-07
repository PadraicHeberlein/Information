namespace Information
{
    public class Symbol
    {
        const int eightBitBase = 256;
        const int sixteenBitBase = 65536;

        private readonly int b;
        private int v;
        private double p;

        public Symbol(int value, int theBase = 2)
        {
            v = value;
            b = theBase;
            p = 0.0;
        }

        public Symbol(char c, bool eightBitAscii = true)
        {
            v = (int)c;
            b = eightBitAscii ? eightBitBase : sixteenBitBase;
            p = 0.0;
        }

        public int Value { get => v; set => v = value; }
        public double Probability { get => p; set => p = value; }
    }
}

