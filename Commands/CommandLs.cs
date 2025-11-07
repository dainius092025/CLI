using System.IO;
namespace CliVerktøy;

public class CommandLs
{
  public static void Run()
  {
    List<string> items = new List<string>();
    Console.WriteLine("this is how far i get");
    string currentDir = Environment.CurrentDirectory;
    string[] files = Directory.GetFiles(currentDir);
    string[] folders = Directory.GetDirectories(currentDir);
    foreach (string file in files)
    {
      string[] locations = file.Split('\\');
      items.Add(locations[^1]);
    }
    foreach (string folder in folders)
    {
      string[] locations = folder.Split('\\');
      items.Add(locations[^1]);
    }
    foreach (string item in items.OrderBy(n => n))
    {
      Console.Write(item + "   ");
    }
  }
}
