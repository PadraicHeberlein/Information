using Information;
using Xunit;

namespace TestInformation
{
    public class TestMessage
    {
        readonly Message testMessage = new Message("This is a test!");
        readonly MessageComparer msgComp = new MessageComparer();

        [Fact]
        public void TestMessage_TestComparer()
        {
            Assert.Equal(testMessage, new Message("This is a test!"),
                msgComp);
        }
    }
}