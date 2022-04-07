using Information;
using Xunit;

namespace TestInformation
{
    public class TestBit
    {
        [Fact]
        public void TestBit_TestConstructorForValueZero()
        {
            Bit testBit = new Bit(0);
            Assert.False(testBit.Value);
        }

        [Fact]
        public void TestBit_TestConstructorForValueOne()
        {
            Bit testBit = new Bit(1);
            Assert.True(testBit.Value);
        }
    }
}
