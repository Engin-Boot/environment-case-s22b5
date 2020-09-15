using Xunit;
using receiver.Utils;
namespace Receiver.Tests
{
    public class TestLogger
    {
        private readonly Logger _logger = new Logger();
        [Fact]
        public void WhenStatusCodeIsOkThenPrintOkMessage()
        {
            var message = "Temperature: ";
            const int statusCode = 0;
            _logger.LoggingToConsole(statusCode,ref message);
            var isFalse=message.Equals("Temperature: Warning");
            Assert.False(isFalse);
            isFalse = message.Equals("Temperature: Error");
            Assert.False(isFalse);
            var isTrue= message.Equals("Temperature: OK");
            Assert.True(isTrue);

        }
    }
}
