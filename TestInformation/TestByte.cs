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

        [Fact]
        public void TestByte_TestGetBitOne()
        {
            Bit expected = new Bit(1);
            Assert.Equal(expected, testByte.Get(1), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitTwo()
        {
            Bit expected = new Bit(1);
            Assert.Equal(expected, testByte.Get(2), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitThree()
        {
            Bit expected = new Bit(1);
            Assert.Equal(expected, testByte.Get(3), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitFour()
        {
            Bit expected = new Bit(0);
            Assert.Equal(expected, testByte.Get(4), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitFive()
        {
            Bit expected = new Bit(0);
            Assert.Equal(expected, testByte.Get(5), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitSix()
        {
            Bit expected = new Bit(1);
            Assert.Equal(expected, testByte.Get(6), bitComp);
        }

        [Fact]
        public void TestByte_TestGetBitSeven()
        {
            Bit expected = new Bit(0);
            Assert.Equal(expected, testByte.Get(7), bitComp);
        }

        [Fact]
        public void TestByte_TestSettingBit()
        {
            Bit expected = new Bit(0);
            testByte.Set(1, 0);
            Assert.Equal(expected, testByte.Get(1), bitComp);
        }

        [Fact]
        public void TestByte_TestFlipplingBit()
        {
            Bit expected = new Bit(0);
            testByte.FlipBit(2);
            Assert.Equal(expected, testByte.Get(2), bitComp);
        }
    }
}
