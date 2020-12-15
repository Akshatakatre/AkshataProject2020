using System;

namespace SwitchExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, j = 4;
            switch (i + j * 2)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 and 2");
                    break;
                    //error occur in this code
                case 3 to 10:
          Console.WriteLine("3 to 10");
                    break;
            }
            Console.ReadKey();

        }
    }
}
