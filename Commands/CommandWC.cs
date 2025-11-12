using System.Text;

namespace CliVerktøy;

/*
Jarands del

Pseudokode:
Rekkefølgen i resultatet skal være det samme uansett rekkefølgen argumentene er gitt i.
Sjekke hver streng i args for å skille ut argumenter til funksjonene og filsti-innputt.

Simpel versjon
public class CommandWc
{
    public static void Run(string[] args)
    {
        ny filstrøm = argsList[0]
        liste c

        For hver streng i args 
        {
            Hvis streng arg starter med 'a-', legg til i en liste. 
        }
        
        For hver streng i argslisten
        {
            Hvis strengen ikke viser til en gyldig fil/mappe 
            {
            Skriv i terminalen: "'streng' er ikke en gyldig fil/mappe."
            } 
            Ellers 
            {
                For hver streng i  
            }
        }
        Hvis innputt ikke er gyldig
    }
}
*/

/**
 * Imitation of Git Bash command wc. Args given must be double-quoted("example").
 */
public class CommandWC
{
    /// <summary>
    ///
    ///
    /// </summary>
    /// <param name="args">commandArgs</param>
    public static void Run(string[] args)
    {
        
        List<string> argList = new();
        List<string> inputList = new();
        FileInfo fileInfo;
        StreamReader streamReader;
        long sumOfAllBytes;
        long sumOfAllLines;
        long sumOfAllWords;
            
        foreach (var arg in args)
        {
            if (arg.Substring(0, 2) == "a-")
            {
                argList.Add(arg);
                Console.WriteLine(arg);
            } else if (arg.Substring(0, 2) != "a-")
            {
                inputList.Add(arg);
                Console.WriteLine(arg);
            }
        }

        foreach (var input in inputList)
        {
            if (File.Exists(input) == false)
            {
                Console.WriteLine($"wc: {input}: No such file or directory");
            }
            else
            {
                if (argList.Count == 0)
                {
                    //argList = {"-c","-l","-w"};
                    string[] sourceArray = { "a-c","a-l","a-w" };
                    argList = sourceArray.ToList();
                }
                long byteCountOfFile = 0;
                long lines = 0;
                long wordsOutput = 0;
                foreach (var arg in argList)
                {
                    if (arg != "a-c" && arg != "a-l" && arg != "a-w")
                    {
                        Console.WriteLine($"wc: unknown option -- {arg}");
                    }
                    fileInfo = new(input);
                    string fileText = File.ReadAllText(input);
                    
                    switch (arg)
                    {
                        case "a-c":
                            //Count byte amount of file.
                            byteCountOfFile = fileInfo.Length;
                            //Console.WriteLine($"Byte count of file from FileInfo: {byteCountOfFile}");
                            break;
                        case "a-l":
                            lines = File.ReadLines(input).LongCount();
                            //Console.WriteLine($"Line count: {lines}");
                            break;
                        case "a-w":
                            char[] delimiters = new char[] { ' ', '.', ',', ';', ':', '?', '!', '\n', '\r', '\t' };
                            string[] words = fileText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            wordsOutput = words.Length;
                            //Console.WriteLine($"Word count: {wordsOutput}");
                            break;
                    }
                    
                }
                
                Console.WriteLine($"{lines} {wordsOutput} {byteCountOfFile} {input}");
            }
        }

        /*string input = String.Join($" ",inputList);
        Console.WriteLine(input);*/
        
        /*FileStream fs = new(inputList[0], FileMode.Open);
        var writenewfile = fs.GetType();
        Console.WriteLine($"type: {writenewfile}");
        
        
        using (StreamReader reader = new(fs))
        {
            string text = reader.ReadToEnd();
            
            Console.WriteLine(text);
            int utf8bytecount = Encoding.UTF8.GetByteCount(text);
            
            Console.WriteLine($"Byte count of string from StreamReader: {utf8bytecount}");
        }*/
        
        
    }
    
    /*public static Encoding DetectEncodingWithBOM(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fs, Encoding.Default, detectEncodingFromByteOrderMarks: true, leaveOpen: false))
            {
                // Read a small amount to trigger BOM detection
                reader.Peek(); 
                return reader.CurrentEncoding;
            }
        }
    }*/
}