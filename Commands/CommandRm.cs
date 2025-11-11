namespace CliVerktøy;

public class CommandRm
{
    public static void Run(string[] arguments)
    {
        var filePath = arguments[0];
        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("File can not be null or whitespace!");
            return;
        }
        else if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Deletion successful!");
            }
            else
            {
                Console.WriteLine("Error, file does not exist.");
            }
        
    }
}