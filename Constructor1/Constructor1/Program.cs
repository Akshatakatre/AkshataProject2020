using System;

namespace Constructor1
{
   public class Program
    {
        private Program()
        {
        }

        public static int count_number;

        public static int Count()
        {
            return ++count_number;
        }
        static void Main(string[] args)
        {
            Program.count_number = 26;
            Program.Count();

            Console.WriteLine(Program.count_number);

            Program.Count();

            Console.WriteLine(Program.count_number);
            Console.ReadKey();
        }
    }
}
