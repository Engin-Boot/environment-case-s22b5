using receiver.Data;
using System;

namespace receiver.Utils

{
    internal class DataValidator
    {
        internal bool ValidateReceivedData(string receivedData, ref EnvironmentData environmentData)
        {
            
            var isValid = false;

            var environmentDataString = receivedData.Split(',');
            if (!receivedData.Equals("File Does not exist"))
            {
                try
                {
                    environmentData.Temperature = double.Parse(environmentDataString[0]);
                    environmentData.Humidity = double.Parse(environmentDataString[1]);
                    Console.WriteLine(environmentData);
                    Console.WriteLine();
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: "+e.Message);
                    isValid = false;
                }

            }
            else
            {
                Console.WriteLine("File Does not exist");
                Environment.Exit(-1);
            }

            return isValid;
    
        }
    }
}