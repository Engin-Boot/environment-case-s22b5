using System;
using receiver.Data;
using receiver.Utils;

namespace receiver
{
     static class Program
    {
        private static readonly DataReceiver DataReceiver;
        private static readonly DataValidator DataValidator;
        private static readonly RangeChecker rangeChecker;
        private static readonly Logger Logger;
        

        static Program()
        {
            DataReceiver = new DataReceiver();          
            DataValidator = new DataValidator();
            rangeChecker = new RangeChecker();
            Logger = new Logger();

        }
         static void Main()
        {
            string receivedData;
            var environmentData = new EnvironmentData();
            while ((receivedData = DataReceiver.ReceiveViaConsole()) != null)
            {
                var isValid = DataValidator.ValidateReceivedData(receivedData, ref environmentData);
                if (!isValid) continue;
                var temperatureStatusCode =
                    rangeChecker.CheckTemperatureAndReturnStatusCode(environmentData.Temperature);
                var humidityStatusCode = rangeChecker.CheckHumidityAndReturnStatusCode(environmentData.Humidity);

                Logger.LoggingToConsole(temperatureStatusCode, "Temperature: ");
                Logger.LoggingToConsole( humidityStatusCode, "Humidity: ");
                Console.WriteLine();
            }
        }
    }
}
