namespace CliVerktøy;

public class CommandEcho
{
  public static void Run(string[] args)
  {//run a foreach loop so we can concatenate args with single space
    string currentDir = Environment.CurrentDirectory;
    Console.WriteLine(currentDir);
    foreach (string arg in args)
    {
      Console.Write(arg + " ");
    }
  }
}