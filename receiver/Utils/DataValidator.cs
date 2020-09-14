using receiver.Data;
using System;

namespace receiver.Utils

{
    internal class DataValidator
    {
        internal bool validateReceivedData(string receivedData, ref EnvironmentData environmentData)
        {
            
            bool isValid = false;
            //environmentData = default(EnvironmentData);
            
            if (!receivedData.Equals("File Does not exist"))
            {
                string[] environmentDataString = receivedData.Split(',');
                try
                {

                    //string date = environmentDataString[0] + " " + environmentDataString[1];
                    //DateTime datetime = DateTime.ParseExact(date, "dd-MM-yyyy HH:mm", null);
                    //environmentData.dateTime = datetime;
                    //environmentData.temperature = double.Parse(environmentDataString[2]);
                    //environmentData.humidity = double.Parse(environmentDataString[3]);


                    environmentData.temperature = double.Parse(environmentDataString[0]);
                    environmentData.humidity = double.Parse(environmentDataString[1]);
                    Console.WriteLine(environmentData.temperature);
                    Console.WriteLine(environmentData.humidity);

                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                isValid = true;
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

/*
 if (line.Contains(",")) 
                        {
                            string[] environmentData = line.Split(',');
                            string date = environmentData[0] + " " + environmentData[1];
                            DateTime datetime = DateTime.ParseExact(date, "dd-MM-yyyy HH:mm", null);
                            data.dateTime = datetime;
                            data.temperature = double.Parse(environmentData[2]);
                            data.humidity = double.Parse(environmentData[3]);
                            Console.WriteLine("Temperature="+ data.temperature + "\n Humidity= " + data.humidity + " " + "Date=" + datetime+"\n\n\n");
                        }


Environments data;

internal FileReader()
{
    data = new Environments();
}


internal class Environments
{
    internal DateTime dateTime { get; set; }
    internal double temperature { get; set; }
    internal double humidity { get; set; }
}
*/