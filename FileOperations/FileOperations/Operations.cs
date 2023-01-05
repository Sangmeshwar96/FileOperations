using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Operations
    {
        public static void FileExists(string filepath)
        {
            if (File.Exists(filepath))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File Not Exists");
        }
        public static void ReadLines(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
                Console.WriteLine("File Not Exists");
        }
        public static void ReadText(string filepath)
        {
            if (File.Exists(filepath))
            {
                string lines = File.ReadAllText(filepath);
                Console.WriteLine(lines);
            }
            else
                Console.WriteLine("File Not Exists");
        }
        public static void FileCopy(string filepath, string newfilepath)
        {
            if (File.Exists(filepath))
            {
                File.Copy(filepath, newfilepath);

            }
            else
                Console.WriteLine("File Not Exists");

        }
        public static void FileDelete(string newfilepath)
        {
            if (File.Exists(newfilepath))
            {
                File.Delete(newfilepath);

            }
            else
                Console.WriteLine("File Not Exists");
        }
        public static void FileStreamReader(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    while (sr.ReadLine() != null)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                }
            }
            else
                Console.WriteLine("File Not Exists");
        }
        public static void FileStreamWriter(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (StreamWriter sr = new StreamWriter(filepath))
                {
                    string word = "Straem Reader And Writer";
                    sr.WriteLine(word);
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(filepath));
                }
            }
            else
                Console.WriteLine("File Not Exists");

        }
    }
}