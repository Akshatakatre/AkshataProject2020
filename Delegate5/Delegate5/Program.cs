using System;

namespace Delegate5
{
    public class Operation
    {
        public static void One()
        {
            Console.WriteLine("Hello... one.... ");
            throw new Exception("Error");
        }
        public static void Two()
        {
            Console.WriteLine("Hello...... Two.....");
        }
    }
    class Program
    {
        delegate void DelOp();

        static void Main(string[] args)
        {
            DelOp obj = Operation.One;
            obj += Operation.Two;

            Delegate[] del = obj.GetInvocationList();

            foreach (DelOp d in del)
            {
                try
                {
                    d();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error caught");
                }
            }
            Console.ReadKey();
        }
    }
}
