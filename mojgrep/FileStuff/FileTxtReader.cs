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
                    string[] text;
                    if (File.Exists(path))
                        text = File.ReadAllLines(path);
                    else
                    {
                        string exeLocation = AppDomain.CurrentDomain.BaseDirectory;
                        Console.WriteLine(Path.Combine(exeLocation, path));
                        text = File.ReadAllLines(Path.Combine(exeLocation, path));
                    }
                    IDataConverter dataConverter = new DataTxtConverter(text);
                    return dataConverter;
                }
                catch (Exception)
                {
                    Console.Write("File not exist");
                    Environment.Exit(1);
                }
            }
            return new DataTxtConverter(new []{""});
        }
    }
}