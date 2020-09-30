using System;

namespace PolymorphismExample10
{
    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base Class A Test Method");
        }
    }
    public class B : A
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived Class B Method");
        }
        public override void Test()
        {
            Console.WriteLine("Derived Class B Test Method");
        }

    }

    public class C : B
    {
       /* public override void GetInfo()
        {
            //Console.WriteLine("Age: {0}", base.age);
        }*/
        public override void Test()
        {
            Console.WriteLine("Derived Class C Test Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.GetInfo();
            c.Test();
            Console.ReadKey();
        }
    }
}
