namespace mojgrep.CommandStuff.FinderStuff
{
    public interface IFinder
    {
        string[] Find(string chain, string[] text);
    }
}