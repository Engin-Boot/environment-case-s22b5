using Xunit;
using receiver.Utils;
namespace Receiver.Tests
{
    public class ReceiverTest
    {
        private readonly RangeChecker rangeChecker = new RangeChecker();
        [Fact]
        public void WhenTemperatureIsInNormalRangeThenReturnOkStatusCode()
        {
            
            var temperature = 20;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = 37;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = 42;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = -2;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
        }
        [Fact]
        public void WhenTemperatureIsInWarningRangeThenReturnWarningStatusCode()
        {
            var temperature = 4;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 2;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 0;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 30;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 37;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 40;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
        }
        [Fact]
        public void WhenTemperatureIsInErrorRangeThenReturnErrorStatusCode()
        {
            var temperature = 0;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 2;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 40;
            Assert.True(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 30;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 37;
            Assert.False(rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
        }
    }
}
