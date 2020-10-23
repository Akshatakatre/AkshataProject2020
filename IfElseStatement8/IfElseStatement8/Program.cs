using System;

namespace IfElseStatement8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b = -1;
            //check the error will occur or not
            if (Convert.ToBoolean(++a = ++b))
                Console.WriteLine("a");
            else
                Console.WriteLine("b");
            Console.ReadKey();

        }
    }
}
