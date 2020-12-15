using System;

namespace SwitchExample9
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'p';
            switch (ch)
            {
                case 'p':
                    Console.WriteLine("coco" + "\t" + Convert.ToInt32(ch));
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.WriteLine("main");
            Console.ReadKey();
        }
    }
}
