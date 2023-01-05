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
    }
}