using System;
using System.Text.RegularExpressions;

namespace mojgrep.DisplayStuff
{
    public class ConsolDisplayer : IDisplayer
    {
        private string _chain;
        private ConsoleColor _color;
        public ConsolDisplayer(string chain, ConsoleColor color)
        {
            _chain = chain;
            _color = color;
        }

        public void Display(string[] textToDisplay)
        {
            foreach (var oneLine in textToDisplay)
            {
                string pattern = "(" + _chain + ")";
                string[] splited = Regex.Split(oneLine, pattern);
                ConsoleColor orginConsoleColor = Console.ForegroundColor;
                foreach (var splitedWords in splited)
                {
                    ColoredConsoleWrite(Regex.IsMatch(splitedWords, _chain) ? _color : orginConsoleColor, splitedWords);
                }
                NewLine();
            }
        }

        private void ColoredConsoleWrite(ConsoleColor color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }

        private void NewLine()
        {
            Console.WriteLine();
        }

    }
}