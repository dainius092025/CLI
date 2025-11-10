namespace CliVerktøy;

public class CommandTail
{
  public static void Run(string filePath)
  {
    List<string> lines = FileHelper.ReadFile(filePath);
    for (int i = 1; i < 11; i++)
    {
      Console.WriteLine(lines[^i]);
    }
  }
}