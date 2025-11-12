using System;
using System.IO;

namespace CliVerktøy;

public class CommandCD
{

    public static void Run(string[] args)
    {
        string dir = "";
        foreach (string arg in args)
        {
            dir = dir + arg;
        }

        Directory.SetCurrentDirectory(dir);
        Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());


    }


}
