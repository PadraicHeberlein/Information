using Information;
using Xunit;

namespace TestInformation
{
    public class TestMessage
    {
        readonly Message testMessage = new Message("This is a test!");
        readonly MessageComparer msgComp = new MessageComparer();
        readonly SymbolComparer symComp = new SymbolComparer();
        readonly Symbol T = new Symbol('T');

        [Fact]
        public void TestMessage_TestComparer()
        {
            Assert.Equal(testMessage, new Message("This is a test!"),
                msgComp);
        }

        [Fact]
        public void TestMessage_TestLengthMethod()
        {
            Assert.Equal(15, testMessage.Length());
        }

        [Fact]
        public void TestMessage_TestGetMethod()
        {
            Assert.Equal(T, testMessage.Get(0), symComp);
        }

        [Fact]
        public void TestMessage_TestSetMethod()
        {
            Message actual = new Message(testMessage);
            actual.Set(10, T);
            Assert.Equal(new Message("This is a Test!"), 
                actual, msgComp);
        }

        [Fact]
        public void TestMessage_TestContainsMethod()
        {
            Assert.True(testMessage.Contains(T));
        }

        [Fact]
        public void TestMessage_TestAddMethodWithSymbolArg()
        {
            Message actual = new Message(testMessage);
            actual.Add(new Symbol('!'));
            Assert.Equal(new Message("This is a test!!"),
                actual, msgComp);
        }

        [Fact]
        public void TestMessage_TestAddMethodWitCharArg()
        {
            Message actual = new Message(testMessage);
            actual.Add('!');
            Assert.Equal(new Message("This is a test!!"),
                actual, msgComp);
        }
    }
}