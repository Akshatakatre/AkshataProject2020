﻿using System;

namespace AbstractClassExample1
{
    abstract class Info
    {
        abstract public void GetDetails(string x, string y, int z);
    }

    class User : Info
    {
        public override void GetDetails(string a, string b, int c)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine("****Abstract Class Example****");
            u.GetDetails("Akshata ", "Nagpur", 24);
            Console.ReadKey();
        }
    }
}