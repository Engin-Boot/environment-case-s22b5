using System;
using System.Collections.Generic;
using System.IO;

namespace sender.Utils
{
    internal class FileReader
    {        
        internal List<string> ReadCSV(string path)
        {
            var dataArray = new List<string>();
            if (File.Exists(path))
            {
                using(StreamReader reader =new StreamReader(path))
                {
                    var line = reader.ReadLine();
                    while ((line = reader.ReadLine() )!= null)
                    {
                        dataArray.Add(line);
                    }
                }
                
            }
            else
            {
                Console.WriteLine("File Does not exist");
                Environment.Exit(-1);
            }
            return dataArray;
        }
    }
}