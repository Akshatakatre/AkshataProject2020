using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract4
{
    abstract class Abstclass
    {
        public abstract void a_method();
        public void non_amethod()
        {
            Console.WriteLine("this is the normal method of abstract class");
        }
    }
    class Subclass:Abstclass
    {
        public override void a_method()
        {
            Console.WriteLine("this is abstract method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abstclass a = new Subclass();
            a.a_method();
            a.non_amethod();
            Console.ReadKey();
        }
    }
}
