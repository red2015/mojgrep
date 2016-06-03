using System;
using System.Collections.Generic;
using System.Linq;
using mojgrep.CommandStuff;
using mojgrep.CommandStuff.ColorStuff;
using mojgrep.CommandStuff.FinderStuff;

namespace mojgrep
{
    public class Command
    {
        private string[] _args;
        private ColorStatus _colorStatus;
        private FinderStatus _finderStatus;
        private string _chain;
        private string _path;

        public Command(string[] args)
        {
            _args = args;
            _colorStatus = ColorStatus.NotColored;
            _finderStatus = FinderStatus.Containing;
            _chain = String.Empty;
            _path = String.Empty;
        }

        public bool ReturnCommands(out FinderStatus finderStatus, out ColorStatus colorStatus, out string chain,
            out string path)
        {
            finderStatus = FinderStatus.Containing;
            colorStatus = ColorStatus.NotColored;
            chain = String.Empty;
            path = String.Empty;
            if (_args.Length < 1)
            {
                return true;
            }
            bool isError = AssingStatus();
            finderStatus = _finderStatus;
            colorStatus = _colorStatus;
            chain = _chain;
            path = _path;
            return isError;
        }

        private bool AssingStatus()
        {
            var arguments = _args.ToList();
            if (arguments.Count <= 0)
            {
                return true;
            }
            if (arguments.Contains("-v"))
            {
                _finderStatus = FinderStatus.NotContaining;
                RemoveCommand(arguments, "-v");
            }
            if (arguments.Contains("-color"))
            {
                _colorStatus = ColorStatus.Colored;
                RemoveCommand(arguments, "-color");
            }
            if (arguments.Count <= 0)
                return true;
            
            _chain = arguments.FirstOrDefault();
            if (arguments.Count > 1)
            {
                _path = arguments.LastOrDefault();
            }
            return false;
        }

        private static void RemoveCommand(List<string> arguments, string command)
        {
            int index = arguments.IndexOf(command);
            if (index < 0)
                return;
            arguments.RemoveAt(index);
        }
    }
}