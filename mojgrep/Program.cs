﻿using System;
using mojgrep.CommandStuff;
using mojgrep.DisplayStuff;

namespace mojgrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Command comand = new Command(args);
            GrepManager grepManager = new GrepManager(comand);
            grepManager.ExecuteGrep();
        }
    }
}
