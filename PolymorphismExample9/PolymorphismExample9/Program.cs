using System;

namespace PolymorphismExample9
{
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Hello... This is base class method.");
        }
    }
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Hello.. this is derived class method.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
            Console.ReadKey();
        }
    }
}
