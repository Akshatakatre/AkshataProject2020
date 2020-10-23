using System;

namespace IfElseStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 30;
            int j = 25 % 25;
            if (Convert.ToBoolean(Convert.ToInt32(i = j)))
            {
                Console.WriteLine("In if");
            }
            else
            {
                Console.WriteLine("In else");
            }
            Console.WriteLine("In main");
            Console.ReadKey();

        }
    }
}
