using System;

namespace receiver.Utils
{
    internal class Logger
    {
        internal void LoggingToConsole(int statusCode, string prefixMessage)
        {
            string message;
            
            switch (statusCode)
            {
                case ReceiverConstants.Warning:
                    message = prefixMessage + "Warning";
                    break;
                case ReceiverConstants.Error:
                    message = prefixMessage + "Error";
                    break;
                default:
                    message = prefixMessage + "OK";
                    break;
            }
            Console.WriteLine(message);

        }
    }
}