using System;

namespace IfElseStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter:");
            char c = (char)Console.Read();
            if (Char.IsDigit(c) == true)
                Console.WriteLine("A number");
            else if (char.IsLower(c) == true)
                Console.WriteLine("A lowercase letter");
            else if (char.IsUpper(c) == true)
                Console.WriteLine("An uppercase letter");
            Console.ReadKey();

        }
    }
}
