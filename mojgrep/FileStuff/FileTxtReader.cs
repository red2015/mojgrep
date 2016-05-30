using System.IO;

namespace mojgrep.FileStuff
{
    public class FileTxtReader : IReader
    {
        public IDataConverter Read(string path)
        {
            string[] text = File.ReadAllLines(path);
            IDataConverter dataConverter = new DataTxtConverter(text);
            return dataConverter;
        }
    }
}