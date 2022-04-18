using System;
using System.Collections.Generic;

namespace Information
{
    public static class Processing
    {
        public static double Entropy(Message message)
        {
            Message alphabet = GetAlphabet(message);
            double entropy = 0.0;

            // TODO: Finish him!

            return entropy;
        }
        // Helper method for the Entropy() method above.
        public static Message GetAlphabet(Message message)
        {
            Message alphabet = new Message();
            int n = message.Length();

            for (int i = 0; i < n; i++)
            {
                Symbol next = message.Get(i);

                if (!alphabet.Contains(next))
                    alphabet.Add(next);
            }

            return alphabet;
        }
        // Helper method for the Entropy() method above.
        public static double GetProbabilityOf(Symbol symbol, Message message)
        {
            int n = message.Length();
            double probability = 0.0;

            for (int i = 0; i < n; i++)
            {
                if (symbol.Equals(message.Get(i)))
                    probability++;
            }

            return probability / n;
        }
        // Helper method for the Entropy() method above.
        private static void AssignProbabilities(List<Symbol> message, List<Symbol> alphabet)
        {
            throw new NotImplementedException();
        }

        // TODO: Need to add an arbitrary base log method...
        public static Bit BitExtractor(byte target, int position)
        {
            byte maskedByte = 0x00;
            switch (position)
            {
                case Global.ZEROTH_POSITION:
                    maskedByte = ApplyMask(Global.ZEROTH_BIT_MASK, target);
                    break;
                case Global.FIRST_POSITION:
                    maskedByte = ApplyMask(Global.FIRST_BIT_MASK, target);
                    break;
                case Global.SECOND_POSITION:
                    maskedByte = ApplyMask(Global.SECOND_BIT_MASK, target);
                    break;
                case Global.THIRD_POSITION:
                    maskedByte = ApplyMask(Global.THIRD_BIT_MASK, target);
                    break;
                case Global.FOURTH_POSITION:
                    maskedByte = ApplyMask(Global.FOURTH_BIT_MASK, target);
                    break;
                case Global.FIFTH_POSITION:
                    maskedByte = ApplyMask(Global.FIFTH_BIT_MASK, target);
                    break;
                case Global.SIXTH_POSITION:
                    maskedByte = ApplyMask(Global.SIXTH_BIT_MASK, target);
                    break;
                case Global.SEVENTH_POSITION:
                    maskedByte = ApplyMask(Global.SEVENTH_BIT_MASK, target);
                    break;
            }

            return ExtractBit(maskedByte, position); ;
        }
        static Bit ExtractBit(byte target, int position)
        {
            int result = (int)target >> position;

            return result == 1 ? Bit.ONE : Bit.ZERO;
        }
        public static byte GetUpperByte(char symbol)
        {
            int upper = (ushort)symbol & Global.UPPER_BYTE_MASK;

            return (byte)(upper >> Global.BYTE_WIDTH);
        }
        public static byte GetLowerByte(char symbol)
        {
            return (byte)((ushort)symbol & Global.LOWER_BYTE_MASK);
        }
        public static byte ApplyMask(byte mask, byte target)
        {
            return (byte)(target & mask);
        }
    }
}
