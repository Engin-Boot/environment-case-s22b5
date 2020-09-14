using sender.Utils;
using System.Collections.Generic;
using System.Threading;
namespace sender
{
    public class Program
    {
        private static FileReader fileReader;
        private static DataSender dataSender;
        static Program()
        {
            fileReader = new FileReader();
            dataSender = new DataSender();
        }
        static void Main(string[] args)
        {
            List<string> dataToSend =fileReader.ReadCSV(Utils.SenderConstants.csvFilePath);
            //Console.WriteLine(dataToSend);
            foreach(string data in dataToSend)
            {
                dataSender.SendViaConsole(data);
                Thread.Sleep(SenderConstants.senderWaitingTime);
            }
            
        }
    }
}
