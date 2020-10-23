using System;

namespace ForLoopExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i--)) ;
            Console.ReadKey();

        }
    }
}
