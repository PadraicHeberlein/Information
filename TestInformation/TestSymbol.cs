using Information;
using Xunit;

namespace TestInformation
{
    public class TestSymbol
    {
        readonly Symbol T = new Symbol('T');
        
        [Fact]
        public void TestSymbol_TestValueGet()
        {
            Assert.Equal((int)('T'), T.Value);
        }

        [Fact]
        public void TestSymbol_TestValueSet()
        {
            T.Value = (int)('S');
            Assert.Equal((int)('S'), T.Value);
        }
    }
}
