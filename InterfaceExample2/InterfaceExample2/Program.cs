using System;

namespace InterfaceExample2
{
    interface ITransaction
    {
        void doTransaction();
    }
    class ConnectDatabase
    {
        public void connect()
        {
            Console.WriteLine("Connect database");
        }
    }

    class Transaction : ConnectDatabase, ITransaction
    {
        public void doTransaction()
        {
            Console.WriteLine("processing transaction");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction();
            t.connect();
            t.doTransaction();
            Console.ReadKey();
        }
    }
}
