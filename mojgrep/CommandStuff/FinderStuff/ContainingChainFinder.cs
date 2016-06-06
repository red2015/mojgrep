using System.Linq;
using System.Text.RegularExpressions;

namespace mojgrep.CommandStuff.FinderStuff
{
    public class ContainingChainFinder : IFinder
    {
        public string[] Find(string chain, string[] text)
        {
            var findedText = text.Where(x =>Regex.IsMatch(x, chain)).Select(x => x).ToArray();
            return findedText;
        }
    }
}