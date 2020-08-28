using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateconstructor
{
    class privateconst
    {
        public static string name="akshata";
        private privateconst()
        {

        }
        public static void show()
        {
            name = "ak";
            Console.WriteLine("the name is:" + name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            privateconst.name ="akshu";
            privateconst.show();
            Console.ReadKey();

        }
    }
}
