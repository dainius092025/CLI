using System.Security.Cryptography.X509Certificates;

namespace CliVerktøy;

public class CommandCat
{
    public static void Cat(string[] args)
    {
        var filePath = args[0];

        if (File.Exists(filePath))
        {
            string? readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
        }
        return;
    }


    
    
}