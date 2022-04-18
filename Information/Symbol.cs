using System;
using System.Collections.Generic;

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

        public Symbol(Symbol other)
        {
            v = other.v;
            b = other.b;
            p = other.p;
        }

        public int Value { get => v; set => v = value; }
        public double Probability { get => p; set => p = value; }
        public bool Equals(Symbol other) { return v == other.v; }
        public override string ToString() { return (char)v + ""; }
    }

    public class SymbolComparer : IEqualityComparer<Symbol>
    {
        public bool Equals(Symbol x, Symbol y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Symbol obj)
        {
            throw new NotImplementedException();
        }
    }
}

