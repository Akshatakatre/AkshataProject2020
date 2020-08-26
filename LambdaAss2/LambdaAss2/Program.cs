using System;

namespace LambdaAss2
{
    class Order
    {
        public int orderid { get; set; }
        public string productname { get; set; }
        public float rate { get; set; }
        public int quantity { get; set; }
    }
    class Program
    {
        delegate void orderdelegate(Order ord);
        static void Main(string[] args)
        {
            orderdelegate od = d =>
              {
                  Console.WriteLine("order id is " + d.orderid);
                  Console.WriteLine("product name is " + d.productname);
                  Console.WriteLine("rate is " + d.rate);
                  Console.WriteLine("quantity is " + d.quantity);
              };
            Console.WriteLine("enter order id");
            int oid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product name");
            string pn = Console.ReadLine();
            Console.WriteLine("enter the rate");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the quantity");
            int q = int.Parse(Console.ReadLine());
            Order o = new Order() { orderid = oid, productname = pn, rate = r, quantity = q };
            od(o);
            Console.ReadKey();
        }
    }
}
