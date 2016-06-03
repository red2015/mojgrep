using System;

namespace mojgrep.CommandStuff.FinderStuff
{
    class FinderFactory
    {
        public static IFinder GetFinder(FinderStatus finderStatus)
        {
            switch (finderStatus)
            {
                case FinderStatus.NotContaining:
                    return new NotContainingChainFinder();
                case FinderStatus.Containing:
                    return new ContainingChainFinder();
                default:
                    throw new ArgumentOutOfRangeException(nameof(finderStatus), finderStatus, null);
            }
        }
    }
}
