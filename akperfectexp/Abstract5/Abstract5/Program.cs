using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract5
{
    abstract class Animals
    {
        public abstract void cats();
        public abstract void dogs();
    }
    class Cats:Animals
    {
        public override void cats()
        {
            Console.WriteLine("Cats meow.");    
        }
        public override void dogs()
        {
            
        }
    }
    class Dogs:Animals
    {
        public override void cats()
        {
           
        }
        public override void dogs()
        {
            Console.WriteLine("Dods bark.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals a = new Cats();
            a.cats();
            Animals a1 = new Dogs();
            a1.dogs();
            Console.ReadKey();
        }
    }
}
