
namespace receiver.Utils
{
    internal class DataChecker
    {
        internal int CheckTemperatureAndReturnStatusCode(double temperature)
        {
            int temperatureStatusCode;
            if ((temperature > 0 && temperature <= 4) || (temperature >= 37 && temperature < 40))
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
            }

            return temperatureStatusCode;
        }

        internal int CheckHumidityAndReturnStatusCode(double humidity)
        {
            int humidityStatusCode;
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

            return humidityStatusCode;
        }
    }
}