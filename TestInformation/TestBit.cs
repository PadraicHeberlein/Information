using Information;
using Xunit;

namespace TestInformation
{
    public class TestBit
    {
        Bit testZero = new Bit(0);
        Bit testOne = new Bit(1);
        BitComparer bComp = new BitComparer();

        [Fact]
        public void TestBit_TestConstructorForValueZero()
        {           
            Assert.False(testZero.Value);
        }

        [Fact]
        public void TestBit_TestConstructorForValueOne()
        {
            Assert.True(testOne.Value);
        }

        [Fact]
        public void TestBit_TestReadonlyZERO()
        {          
            Assert.Equal(testZero, Bit.ZERO, bComp);
        }

        [Fact] void TestBit_TestReadonlyONE()
        {
            Assert.Equal(testOne, Bit.ONE, bComp);
        }
    }
}
