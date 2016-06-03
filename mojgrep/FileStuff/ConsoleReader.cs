using System;
using mojgrep.DataStuff;

namespace mojgrep.FileStuff
{
    public class ConsoleReader : IReader
    {
        public IDataConverter Read(string path)
        {
            string [] data = new[] {Console.ReadLine()};
            IDataConverter dataConverter = new DataTxtConverter(data);
            return dataConverter;
        }
    }
}
