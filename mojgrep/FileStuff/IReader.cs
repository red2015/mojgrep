﻿namespace mojgrep.FileStuff
{
    public interface IReader
    {
        IDataConverter Read(string path);
    }
}