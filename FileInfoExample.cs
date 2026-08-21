using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileInfoExample
    {
        public void CreateFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            using (file.Create())
            {
                // The using ensures the FileStream is disposed/closed.
            }
            Console.WriteLine("File created successfully!");
            Console.WriteLine("File path :- " + file.FullName);
        }
        public void WriteFile()
        {
            // FileInfo doesn't have a direct WriteAllText() like File.
            // We use AppendText() or streams.
            FileInfo file = new FileInfo("test_info.txt");
            using (StreamWriter writer = file.CreateText())
            {
                writer.Write("Hello form FileInfo!");
            }
            Console.WriteLine("Content written successfully!");
        }
        public void AppendFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            using (StreamWriter writer = file.AppendText())
            {
                writer.WriteLine("This content is appended.");
            }
            Console.WriteLine("Content appended successfully!");
            /*
             * CreateText() → Existing content gets replaced
             * AppendText() → Existing content remains + new content added
             */
        }
        public void ReadFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            using (StreamReader reader = file.OpenText())
            {
                string data = reader.ReadToEnd();
                Console.WriteLine("File Content : ");
                Console.WriteLine(data);
            }
        }
        public void CheckFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            if (file.Exists)
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
        public void CopyFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            file.CopyTo("copy_info.txt", true);
            Console.WriteLine("File copied successfully!");
        }

        public void MoveFile()
        {
            FileInfo file = new FileInfo("test_info.txt");
            file.MoveTo("new_info.txt");
            Console.WriteLine("File moved successfully!");
        }

        public void DeleteFile()
        {
            FileInfo file = new FileInfo("copy_info.txt");
            if (file.Exists)
            {
                file.Delete();
                Console.WriteLine("File deleted successfully!");
            }
        }
        public void GetFileInfo()
        {
            FileInfo file = new FileInfo("test_info.txt");
            Console.WriteLine("Name : " + file.Name);
            Console.WriteLine("Full path : " + file.FullName);
            Console.WriteLine("Extension : " + file.Extension);
            Console.WriteLine("Size : " + file.Length + " bytes");
            Console.WriteLine("Created : " + file.CreationTime);
            Console.WriteLine("Modified : " + file.LastWriteTime);
            Console.WriteLine("Directory : " + file.DirectoryName);
        }
    }
}
