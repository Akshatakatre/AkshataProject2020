using System;

namespace SwitchExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9, j = 7;
            switch (i - j + 3)
            {
                case 9:
                    7:
          j += 6;
                    break;
                case 5:
                    i -= 4;
                    break;
            }
            Console.WriteLine(i + "\n" + j);
            Console.ReadKey();
            //compile time error occur
        }
    }
}
