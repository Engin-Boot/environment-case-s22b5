using receiver.Data;
using receiver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace receiver
{
    internal class Program
    {
        private static readonly DataReceiver dataReceiver;
        private static readonly DataValidator dataValidator;
        private static readonly DataChecker dataChecker;
        private static readonly Logger logger;
        

        static Program()
        {
            dataReceiver = new DataReceiver();          
            dataValidator = new DataValidator();
            dataChecker = new DataChecker();
            logger = new Logger();

        }
        static void Main()
        {
            string receivedData;
            EnvironmentData environmentData = new EnvironmentData();
            while ((receivedData = dataReceiver.ReceiveViaConsole()) != null)
            {
                //var receivedData = dataReceiver.ReceiveViaConsole();
                
                var isValid = dataValidator.validateReceivedData(receivedData, ref environmentData);
                if (isValid)
                {
                    var temperatureStatusCode = dataChecker.CheckTemperatureAndReturnStatusCode(environmentData.temperature);
                    var humidityStatusCode = dataChecker.CheckHumidityAndReturnStatusCode(environmentData.humidity);

                    logger.loggingToConsole(temperatureStatusCode, humidityStatusCode);
                }
                else
                {
                    Console.WriteLine("Inconsistent Data");
                }


            }

        }
    }
}
