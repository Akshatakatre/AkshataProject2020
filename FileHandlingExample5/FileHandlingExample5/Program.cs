using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E:\\cshsrpfile.txt", FileMode.Create);
            fs.Close();
            Console.Write("File has been created and the Path is D:\\csharpfile.txt");
            Console.ReadKey();
        }
    }
}
