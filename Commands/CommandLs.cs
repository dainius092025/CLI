using System.IO;
namespace CliVerktøy;

public class CommandLs
{
  public static void Run()
  {
    List<string> items = new List<string>();
    string currentDir = Environment.CurrentDirectory;
    string[] files = Directory.GetFiles(currentDir);
    string[] folders = Directory.GetDirectories(currentDir);
    char[] notAllowed = ['.'];
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
    var newItems = items.OrderBy(n => n)
                             .Where(x => !notAllowed.Any(b => x.StartsWith(b)))
                             .ToList();
    foreach (string item in newItems)
    {
      Console.Write(item + "   ");
    }
  }
}
