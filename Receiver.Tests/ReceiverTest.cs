using Xunit;
using receiver.Utils;
namespace Receiver.Tests
{
    public class ReceiverTest
    {
        private readonly RangeChecker _rangeChecker = new RangeChecker();
        [Fact]
        public void WhenTemperatureIsInNormalRangeThenReturnOkStatusCode()
        {
            
            var temperature = 20;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = 37;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = 42;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
            temperature = -2;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 0);
        }
        [Fact]
        public void WhenTemperatureIsInWarningRangeThenReturnWarningStatusCode()
        {
            var temperature = 4;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 2;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 0;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 30;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 37;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
            temperature = 40;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 1);
        }
        [Fact]
        public void WhenTemperatureIsInErrorRangeThenReturnErrorStatusCode()
        {
            var temperature = 0;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 2;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 40;
            Assert.True(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 30;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
            temperature = 37;
            Assert.False(_rangeChecker.CheckTemperatureAndReturnStatusCode(temperature) == 2);
        }
    }
}
