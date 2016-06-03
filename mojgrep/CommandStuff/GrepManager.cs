using System;
using mojgrep.CommandStuff.ColorStuff;
using mojgrep.CommandStuff.FinderStuff;
using mojgrep.DataStuff;
using mojgrep.DisplayStuff;
using mojgrep.FileStuff;

namespace mojgrep.CommandStuff
{
    public class GrepManager
    {
        private IFinder _finder;
        private string[] _text;
        private string[] _findedText;
        private string _chain;
        private IDisplayer _displayer;
        private IReader _reader;
        private string _path;
        private Command _comand;

        public GrepManager(Command comand)
        {
            _comand = comand;
        }

        private void Initializated()
        {
            FinderStatus finderStatus;
            ColorStatus colorStatus;
            bool error = _comand.ReturnCommands(out finderStatus, out colorStatus, out _chain, out _path);
            _displayer = new ConsolDisplayer(_chain, ColorConsoleFactory.GetColor(colorStatus));
            if (error)
            {
                _displayer.Display(new string[] {"Incorret data"});
                Environment.Exit(1);
            }
            _finder = FinderFactory.GetFinder(finderStatus);
            if (_path.Equals(string.Empty))
            {
                _reader = new ConsoleReader();
            }
            else
            {
                _reader = new FileTxtReader();
            }
           
            
        }

        private void Find()
        {
            _findedText = _finder.Find(_chain, _text);
        }

        private void Display()
        {
            _displayer.Display(_findedText);
        }

        private void ReadFile()
        {
            IDataConverter dataConverter = _reader.Read(_path);
            _text = dataConverter.GetData();
        }

        public void ExecuteGrep()
        {
            Initializated();
            ReadFile();
            Find();
            Display();
        }
    }
}