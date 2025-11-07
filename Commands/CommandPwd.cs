using System;
using System.IO;

namespace CliVerktøy;

public class CommandPwd
{

    public static string Run()
    {

        Console.WriteLine(Environment.CurrentDirectory);
        return Environment.CurrentDirectory;
    }

}
  
