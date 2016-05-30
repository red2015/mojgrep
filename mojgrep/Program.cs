using System.Linq;
using mojgrep.FileStuff;

namespace mojgrep
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new FileTxtReader();
            IDataConverter dataConverter = reader.Read(@"C:\Users\Michael\Documents\mojgrep\tekst\tekst\dane-text.txt");
            ChainFinder chainFinder = new ChainFinder(dataConverter.GetData());
            
            IDisplayer displayer = new ConsolDisplayer();
            displayer.Display(chainFinder.Find("inny"));
        }
    }

    public class ChainFinder
    {
        private readonly string[] _text;

        public ChainFinder(string[] text)
        {
            _text = text;
        }

        public string[] Find(string chain)
        {
            var text = _text.Where(x => x.Contains(chain)).Select(x => x).ToArray();
            return text;

        }
    }

    public interface IDisplayer
    {
        void Display(string[] textToDisplay);
    }
}
