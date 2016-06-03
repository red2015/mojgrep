using System.Linq;

namespace mojgrep.CommandStuff.FinderStuff
{
    public class NotContainingChainFinder : IFinder
    {
        public string[] Find(string chain, string[] text)
        {
            var findedText = text.Where(x => !x.Contains(chain)).Select(x => x).ToArray();
            return findedText;
        }
    }
}