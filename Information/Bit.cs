namespace Information
{
    public class Bit
    {
        public static readonly Bit ZERO = new Bit(0);
        public static readonly Bit ONE = new Bit(1);
        public Bit(int bit) { Value = bit == 1; }
        public bool Value { get; set; }
    }
}
