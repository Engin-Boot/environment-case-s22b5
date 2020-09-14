using sender.Utils;
using System.Threading;
namespace sender
{
    internal class Program
    {
        private static readonly FileReader fileReader;
        private static readonly DataSender dataSender;
        static Program()
        {
            fileReader = new FileReader();
            dataSender = new DataSender();
        }
        internal static void Main()
        {
            var dataToSend =fileReader.ReadCsv(Utils.SenderConstants.CsvFilePath);
            //Console.WriteLine(dataToSend);
            foreach(string data in dataToSend)
            {
                dataSender.SendViaConsole(data);
                Thread.Sleep(SenderConstants.SenderWaitingTime);
            }
            
        }
    }
}
