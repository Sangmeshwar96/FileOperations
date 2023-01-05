using System;

namespace FileOperations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Operations!");
            string filepath = @"C:\Users\hp\source\repos\FileOperations\FileOperations\Text.txt";
            string newfilepath = @"C:\Users\hp\source\repos\FileOperations\FileOperations\Text2.txt";
            Operations.FileExists(filepath);
            Operations.ReadLines(filepath);
            Operations.ReadText(filepath);
            Operations.FileCopy(filepath, newfilepath);
            Operations.FileDelete(newfilepath);
        }
    }
}