using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class Bankacc
    {
        private string name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("name is:" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankacc b = new Bankacc();
            b.SetName("akshu");
            b.Show();
            Console.ReadKey();
        }
    }
}
