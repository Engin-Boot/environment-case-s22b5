
namespace receiver.Utils
{
    internal class DataChecker
    {
        internal int CheckTemperatureAndReturnStatusCode(double temperature)
        {
            int temperatureStatusCode;
            /*if ((temperature > 0 && temperature <= 4) || (temperature >= 37 && temperature < 40))
            {
                temperatureStatusCode= 1; // warning
            }
            else if((temperature <= 0) || (temperature >= 40))
            {
                temperatureStatusCode= 2; // error
            }
            else
            {
                temperatureStatusCode= 0; // OK
            }*/
            if (temperature > 4 && temperature < 37)
                temperatureStatusCode = 0;
            else if (IsErrorTemperature(temperature))
                temperatureStatusCode = 2;
            else
                temperatureStatusCode = 1;
            return temperatureStatusCode;
        }

        private static bool IsErrorTemperature(double temperature)
        {
            return temperature <= 0 || temperature >= 40;
        }

        internal int CheckHumidityAndReturnStatusCode(double humidity)
        {
            int humidityStatusCode;
            /*
            if (humidity >= 70 && humidity < 90)
            {
                humidityStatusCode= 1;// warning
            }
            else if (humidity >= 90)
            {
                humidityStatusCode= 2;// error
            }
            else
            {
                humidityStatusCode= 0;// OK   
            }
            */
            if (humidity < 70)
                humidityStatusCode = 0;
            else if (humidity >= 90)
                humidityStatusCode = 2;
            else
                humidityStatusCode = 1;
            return humidityStatusCode;
        }
    }
}