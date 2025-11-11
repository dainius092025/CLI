namespace CliVerktøy;

public class FileHelper
{
  //returns a list, takes one input and its a filepath to our destination
  public static List<string> ReadFile(string filePath)
  {
    //creates a list and fills with lines from our filepath destination
    List<string> lines = new List<string>();
    // if file exists it reads all lines at once an stores them inside an aaray called allLines
    //each element in allLines is one line fromthe file
    if (File.Exists(filePath))
    {
      string[] allLines = File.ReadAllLines(filePath);
      //this looops through allines, takes one line at a time adds it new list which will be our uotput
      foreach (string line in allLines)
      {
        lines.Add(line);
      }
    }
    //if nothing then nothing
    else
    {
      Console.WriteLine($"File does nt exsist: " + filePath);
    }
    return lines;
  }
}

