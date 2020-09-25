using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample6
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            FileStream fsSource = new FileStream("E:\\csharpfile.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
