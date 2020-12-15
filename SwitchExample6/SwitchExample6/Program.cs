using System;

namespace SwitchExample6
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (5)
            {
                case 5.0f:
                    Console.WriteLine("harsh");
                    break;
                case 5:
                    Console.WriteLine("amish");
                    break;
                case 5.0L:
                    Console.WriteLine("ANKIT");
                    break;
                default:
                    Console.WriteLine("ashish");
            }
            Console.ReadLine();
            //error occur
        }
    }
}
