using System;
using receiver.Data;
using receiver.Utils;

namespace receiver
{
    internal class Program
    {
        private static readonly DataReceiver DataReceiver;
        private static readonly DataValidator DataValidator;
        private static readonly DataChecker DataChecker;
        private static readonly Logger Logger;
        

        static Program()
        {
            DataReceiver = new DataReceiver();          
            DataValidator = new DataValidator();
            DataChecker = new DataChecker();
            Logger = new Logger();

        }
        internal static void Main()
        {
            string receivedData;
            var environmentData = new EnvironmentData();
            while ((receivedData = DataReceiver.ReceiveViaConsole()) != null)
            {
                var isValid = DataValidator.ValidateReceivedData(receivedData, ref environmentData);
                if (!isValid) continue;
                var temperatureStatusCode =
                    DataChecker.CheckTemperatureAndReturnStatusCode(environmentData.Temperature);
                var humidityStatusCode = DataChecker.CheckHumidityAndReturnStatusCode(environmentData.Humidity);

                Logger.LoggingTemperatureToConsole(temperatureStatusCode);
                Logger.LoggingHumidityToConsole( humidityStatusCode);
                Console.WriteLine();
            }
        }
    }
}
