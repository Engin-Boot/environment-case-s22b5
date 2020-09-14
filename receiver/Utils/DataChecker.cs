using System;

namespace receiver.Utils
{
    internal class DataChecker
    {
        internal int CheckTemperatureAndReturnStatusCode(double temperature)
        {

            if ((temperature > 0 && temperature <= 4) || (temperature >= 37 && temperature < 40))
            {
                return 1; // warning
            }
            else if((temperature <= 0) || (temperature >= 40))
            {
                return 2; // error
            }
            else
            {
                return 0; // OK
            }
        }

        internal int CheckHumidityAndReturnStatusCode(double humidity)
        {
            if (humidity >= 70 && humidity < 90)
            {
                return 1;// warning
            }
            else if (humidity >= 90)
            {
                return 2;// error
            }
            else
            {
                return 0;// OK   
            }
        }
    }
}