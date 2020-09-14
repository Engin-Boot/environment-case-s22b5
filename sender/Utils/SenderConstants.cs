using System.IO;

namespace sender.Utils
{
    public static class SenderConstants
    {
        public static string currentDirectory = Directory.GetCurrentDirectory();
        public static string csvFilePath = currentDirectory + @"\environment-data.csv";
        public const int senderWaitingTime = 500;    //In Milliseconds
    }
}
 