using System;
using System.Linq;

namespace mojgrep
{
    public class ConsolDisplayer : IDisplayer
    {
        public void Display(string[] textToDisplay)
        {
            foreach (var s in textToDisplay)
            {
                Console.WriteLine(s);
            }
        }
    }
}