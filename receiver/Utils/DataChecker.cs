namespace receiver.Utils
{
    internal class DataChecker
    {
        internal int CheckTemperatureAndReturnStatusCode(double temperature)
        {
            int temperatureStatusCode;
            if (IsOkTemperature(temperature))
                temperatureStatusCode = ReceiverConstants.Ok;
            else if (IsErrorTemperature(temperature))
                temperatureStatusCode = ReceiverConstants.Error;
            else
                temperatureStatusCode = ReceiverConstants.Warning;
            return temperatureStatusCode;
        }

        private static bool IsOkTemperature(double temperature)
        {
            return (temperature > ReceiverConstants.TemperatureOkLowerLimit && temperature < ReceiverConstants.TemperatureOkUpperLimit);
        }

        private static bool IsErrorTemperature(double temperature)
        {
            return (temperature <= ReceiverConstants.TemperatureErrorLowerLimit || temperature >= ReceiverConstants.TemperatureErrorUpperLimit);
        }

        internal int CheckHumidityAndReturnStatusCode(double humidity)
        {
            int humidityStatusCode;
            if (humidity < ReceiverConstants.HumidityOkUpperLimit)
                humidityStatusCode = ReceiverConstants.Ok;
            else if (humidity >= ReceiverConstants.HumidityErrorLowerLimit)
                humidityStatusCode = ReceiverConstants.Error;
            else
                humidityStatusCode = ReceiverConstants.Warning;
            return humidityStatusCode;
        }
    }
}