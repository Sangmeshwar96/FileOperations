﻿using System;

namespace FileOperations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Operations!");
            string filepath = @"C:\Users\hp\source\repos\FileOperations\FileOperations\Text.txt";
            Operations.FileExists(filepath);
            Operations.ReadLines(filepath);
        }
    }
}