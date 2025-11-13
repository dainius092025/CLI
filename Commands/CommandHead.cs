using System;
using System.IO;
namespace CliVerktøy;

public class CommandHead
{
    public static void Run(string[] args)
    {
        // Hvis ingen argumenter er gitt, vis bruksmelding
        if (args.Length < 1)
        {
            Console.WriteLine("Bruk: head <filnavn> [-n antall_linjer]");
            return;
        }

        string filename = args[0];
        int n = 10; // standard antall linjer

        // Sjekk om brukeren har skrevet -n <tall>
        if (args.Length == 3 && args[1] == "-n")
        {
            if (!int.TryParse(args[2], out n))
            {
                Console.WriteLine("Feil: antall linjer må være et tall.");
                return;
            }
        }

        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                for (int i = 0; i < n; i++)
                {
                    string? line = sr.ReadLine();
                    if (line == null)
                        break;
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Feil: Filen '{filename}' ble ikke funnet.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Noe gikk galt: {e.Message}");
        }
    }
}
