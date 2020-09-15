using sender.Utils;
using System.Threading;
namespace sender
{
    internal static class Program
    {
        private static readonly FileReader FileReader;
        private static readonly DataSender DataSender;
        static Program()
        {
            FileReader = new FileReader();
            DataSender = new DataSender();
        }
        internal static void Main()
        {
            var dataToSend = FileReader.ReadCsv(SenderConstants.CsvFilePath);
            //Console.WriteLine(dataToSend);
            foreach(string data in dataToSend)
            {
                DataSender.SendViaConsole(data);
                Thread.Sleep(SenderConstants.SenderWaitingTime);
            }
            
        }
    }
}
