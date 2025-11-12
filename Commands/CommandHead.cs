using System.Diagnostics.Contracts;

namespace CliVerktøy;

public class CommandHead
{
  public static void Run(string filePath)
  {
    List<string> lines = FileHelper.ReadFile(filePath);
    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine(lines[i]);
    }
  }
}