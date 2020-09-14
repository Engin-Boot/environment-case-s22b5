using System;

namespace receiver.Utils
{
    internal class Logger
    {
        internal void LoggingTemperatureToConsole(int temperatureStatusCode)
        {
            string temperatureMessage;
            
            switch (temperatureStatusCode)
            {
                case ReceiverConstants.Ok:
                    temperatureMessage = "Temperature: OK";
                    break;
                case ReceiverConstants.Warning:
                    temperatureMessage = "Temperature: Warning";
                    break;
                default:
                    temperatureMessage = "Temperature: Error";
                    break;
            }
            Console.WriteLine(temperatureMessage);

        }

        public void LoggingHumidityToConsole(int humidityStatusCode)
        {
            string humidityMessage;
            switch (humidityStatusCode)
            {
                case ReceiverConstants.Ok:
                    humidityMessage = "Humidity: OK";
                    break;
                case ReceiverConstants.Warning:
                    humidityMessage = "Humidity: Warning";
                    break;
                default:
                    humidityMessage = "Humidity: Error";
                    break;
            }
            Console.WriteLine(humidityMessage);
        }
    }
}