using System;

namespace ForLoopExample11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -10;
            for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i++)) ;
            Console.ReadLine();

        }
    }
}
