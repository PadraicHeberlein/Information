using Information;
using System.Collections.Generic;
using Xunit;

namespace TestInformation
{
    public class TestByte
    {
        readonly Byte testDefault = new Byte();
        readonly Byte testByte = new Byte((byte)0b01001110);
        readonly ByteComparer byteComp = new ByteComparer();
        readonly BitComparer bitComp = new BitComparer();

        [Fact]
        public void TestByte_TestDefaultConstructor()
        {
            Assert.Equal(Byte.ZERO, testDefault, byteComp);
        }

        [Fact] 
        public void TestByte_TestGetBitZero()
        {
            Bit expected = new Bit(0);
            Assert.Equal(expected, testByte.Get(0), bitComp);
        }
    }
}
