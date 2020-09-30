using System;

namespace PolymorphismExample8
{
    public class Calculate

    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)

        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.AddNumbers(15, 2);
            c.AddNumbers(1, 26, 3);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadKey();
        }
    }
}
