using System;
using System.IO;

namespace FileHandlingExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"E:\Example.txt";

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }
    }
}
