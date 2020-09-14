using System;

namespace receiver.Utils
{
    internal class Logger
    {
        internal void loggingToConsole(int temperatureStatusCode, int humidityStatusCode)
        {
            var temperatureMessage = "";
            var humidityMessage = "";

            if (temperatureStatusCode == 0)
            {
                temperatureMessage = "Temperature: OK";
            }
            else if (temperatureStatusCode == 1)
            {
                temperatureMessage = "Temperature: Warning";
            }
            else
            {
                temperatureMessage = "Temperature: Error";
            }
            Console.WriteLine(temperatureMessage);

            
            if (humidityStatusCode == 0)
            {
                humidityMessage = "Humidity: OK";
            }
            else if (humidityStatusCode == 1)
            {
                humidityMessage = "Humidity: Warning";
            }
            else
            {
                humidityMessage = "Humidity: Error";
            }
            Console.WriteLine(humidityMessage);
        }
    }
}