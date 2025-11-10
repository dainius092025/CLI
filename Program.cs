namespace CliVerktøy;
//Adding a flowchart
public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please remember to enter the command.");
            Console.WriteLine("It must follow this structure:");
            Console.WriteLine("dotnet run 'your command'");
            //Added new comment on new branch
            return;
        }
        //assigning a new string variable to args first value
        string command = args[0];
        //creating a new string array and assigning the size to one less than args
        string[] commandArgs = new string[args.Length - 1];
        // running for loop to populate an "commandArgs" array from args (skipping the first index value as it is our command)
        for (int i = 1; i < args.Length; i++)
        {
            commandArgs[i - 1] = args[i];
        }
        if (command == "echo")
        {
            CommandEcho.Run(commandArgs);
        }
        else if (command == "cat")
        {
            CommandCat.Cat(commandArgs);
        }
        else if (command == "rm")
        {
            CommandRm.Run(commandArgs);
        }
        
        else if (command == "ls")
        {
            CommandLs.Run();
        }
        else if (command == "Pwd")
        {
            CommandPwd.Run();
        }
        else if (command == "cd")
        {
            CommandCD.Run(commandArgs);
        }
        /*else if (command == "head")
        {
            CommandHead.Run(commandArgs[0]);
        }*/
        else if (command == "tail")
        {
            CommandTail.Run(commandArgs[0]);
        }
        /* else if (command == "cat")
         {
             if (commandArgs.Length > 0)
             {
                 CommandCat.Run(commandArgs[0]);
             }
             else
             {
                 Console.WriteLine("Please provide a file path.");
             }
         }*/
        else
        {
            Console.WriteLine("Unknown command: " + command);
        }




    }
}
