using System;

namespace SwitchExample10
{
    class Program
    {
        static void Main(string[] args)
        {
            int movie = 1;
            switch (movie << 2 + movie)
            {
                default:
                    Console.WriteLine("3 Idiots");
                    break;
                case 4:
                    Console.WriteLine("Ghazini");
                    break;
                case 5:
                    Console.WriteLine("Krishh");
                    break;
                case 8:
                    Console.WriteLine("Race");
                    break;
            }
            Console.ReadLine();

        }
    }
}
