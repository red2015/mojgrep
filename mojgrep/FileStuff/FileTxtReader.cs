using System;
using System.IO;
using mojgrep.DataStuff;

namespace mojgrep.FileStuff
{
    public class FileTxtReader : IReader
    {
        public IDataConverter Read(string path)
        {
            if (!path.Equals(string.Empty))
            {
                try
                {
                    string[] text = File.ReadAllLines(path);
                    IDataConverter dataConverter = new DataTxtConverter(text);
                    return dataConverter;
                }
                catch (Exception)
                {
                    Console.Write("Path not exist");
                    Environment.Exit(1);
                }
            }
            return new DataTxtConverter(new []{""});
        }
    }
}