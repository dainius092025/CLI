# CLI Tools Project

This project is a set of simple command-line tools written in C#.  
It shows how to read input from the user, work with files, and perform basic tasks like printing text or counting lines.

## Tools Included

1. Echo – prints the text you enter.  
   Example: dotnet run echo "Hello world!"

2. Ls – lists files and folders in the current directory.  
   Example: dotnet run ls

3. Pwd – shows the current working directory.  
   Example: dotnet run pwd

4. Cd – changes the current directory.  
   Example: dotnet run cd foldername

5. Head – shows the first lines of a file (default 10 lines).  
   Example: dotnet run head filename.txt

6. Tail – shows the last lines of a file (default 10 lines).  
   Example: dotnet run tail filename.txt

7. Cat – shows the whole file content.  
   Example: dotnet run cat filename.txt

8. Wc – counts lines, words, and bytes in a file.  
   Example: dotnet run wc filename.txt

## How to Run

1. Open terminal in the project folder.
2. Use dotnet run <command> [arguments] to run a tool.
3. Replace <command> with the tool name and [arguments] with any needed input.

Example:  
dotnet run echo "Hello CLI"

## Reflection During Development

What are the similarities and differences between the different tools?  
All tools take commands from the user and perform a specific task. For example, echo prints text, ls shows files and folders, pwd shows the current folder, cd changes the folder, head and tail show parts of a file, cat shows the whole file, and wc counts lines, words, and bytes. The difference is what each tool does and how it works with data. Some tools work with text, others with files or numbers.

Which parts of the code could you reuse across tools?  
Code that reads files (FileHelper), checks if files exist, and writes to the console can be reused in many tools. For example, ReadFile can be used in head, tail, cat, and wc.

Why do you think these tools are still widely used, even though we have modern IDEs and GUIs?  
Because command-line tools are fast, simple, and give more control. They can be automated, work on many systems, and are useful for testing and learning.
