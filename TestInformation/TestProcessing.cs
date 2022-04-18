using System;
using System.Collections.Generic;
using Information;
using Xunit;

namespace TestInformation
{
    public class TestProcessing
    {
        readonly Message hello = new Message("Hello world.");
        readonly Message alphabet = new Message("Helo wrd.");
        readonly MessageComparer msgComp = new MessageComparer();
        readonly BitComparer bitComp = new BitComparer();
        readonly Symbol l = new Symbol('l');
        readonly byte b = 0b00010000;
        
        [Fact]
        public void TestProcessing_TestGetAlphabetMethod()
        {
            Assert.Equal(alphabet, Processing.GetAlphabet(hello),
                        msgComp);
        }

        [Fact]
        public void TestProcessing_TestGetProbabilityOfMethod()
        {
            Assert.Equal(0.25, Processing.GetProbabilityOf(l, hello));
        }

        [Fact]
        public void TestProcessing_TestBitExtractorMethod()
        {
            Assert.Equal(Bit.ONE, Processing.BitExtractor(b, 4),
                        bitComp);
        }

        [Fact]
        public void TestProcessing_TestGetLowerByteMethod()
        {
            Assert.Equal((byte)'A', Processing.GetLowerByte('A'));
        }

        [Fact]
        public void TestProcessing_TestGetUpperByteMethod()
        {
            Assert.Equal(0, Processing.GetUpperByte('A'));
        }
    }
}
