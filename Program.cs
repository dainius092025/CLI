namespace CliVerktøy;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please remember to enter the command.");
            Console.WriteLine("It must follow this structure:");
            Console.WriteLine("dotnet run 'here goes your command+args'");
            return;
        }
    }
}
