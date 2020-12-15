using System;

namespace SwitchExample8
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = Convert.ToChar('a' | 'b' | 'c');
            switch (ch)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("case A|case a");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("case B|case b");
                    break;
                case 'C':
                case 'c':
                case 'D':
                case 'd':
                    Console.WriteLine("case D|case d");
                    break;
            }
            Console.ReadKey();

        }
    }
}
