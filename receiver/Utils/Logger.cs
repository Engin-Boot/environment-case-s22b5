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
                case 0:
                    temperatureMessage = "Temperature: OK";
                    break;
                case 1:
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
                case 0:
                    humidityMessage = "Humidity: OK";
                    break;
                case 1:
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