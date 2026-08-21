using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class FileExample
    {
        // File is a static class, so you don't create an object.
        public void CreateFile()
        {
            string path = "test.txt";
            File.WriteAllText(path, "Hello from C#!");
            Console.WriteLine("File created successfully!");
            Console.WriteLine("File path :- " + Path.GetFileName(path));
        }
        public void WriteFile()
        {
            // // Existing content gets replaced.
            File.WriteAllText("test.txt", "Hello C#!");
            Console.WriteLine("Content written successfully!");
        }
        public void AppendFile()
        {
            // // Existing content remains + new content gets added.
            File.AppendAllText("test.txt","\nThis is an example of File operations");
            Console.WriteLine("Content appended successfully!");
        }
        public void ReadFile()
        {
            // Read entire file → reads the whole file as one string
            string data = File.ReadAllText("test.txt");
            Console.WriteLine("File Content using ReadFile() : ");
            Console.WriteLine(data);
            Console.WriteLine();
        }
        public void ReadAllLines()
        {
            // Read all lines → reads the file line by line
            string[] lines = File.ReadAllLines("test.txt");
            Console.WriteLine("File Content using ReadAllLines() : ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void CheckFile()
        {
            // Check if file exists
            if (File.Exists("test.txt"))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        public void CopyFile()
        {
            // Copy file
            File.Copy("test.txt", "copy.txt", true);
            Console.WriteLine("File copied successfully!");
        }
        public void MoveFile()
        {
            // Move file (This can also effectively rename the file.)
            if (File.Exists("test.txt"))
            {
                if (File.Exists("newTest.txt"))
                {
                    File.Delete("newTest.txt");
                }
                File.Move("test.txt", "newTest.txt");
                Console.WriteLine("File moved successfully!");
            }
        }
        public void DeleteFile()
        {
            if (File.Exists("copy.txt"))
            {
                File.Delete("copy.txt");
                Console.WriteLine("File deleted successfully!");
            }
        }
    }
}
