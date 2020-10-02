using System;

namespace InterfaceExample1
{
    interface IAccount
    {
        string AccountInfo();
        void process();
    }

    class SavingAccount : IAccount
    {

        public string AccountInfo()
        {
            return "Saving Account";
        }
        public void process()
        {
            Console.WriteLine("Process saving account");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            Console.WriteLine(account.AccountInfo());
            account.process();
            Console.ReadKey();
        }
    }
}
