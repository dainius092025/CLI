namespace CliVerktøy;

public class CommandCat
{
  public static void Run(string filepath)
  {
    List<string> lines = FileHelper.ReadFile(filepath);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }
  }
}