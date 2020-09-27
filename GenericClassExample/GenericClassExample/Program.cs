using System;
using System.Collections.Generic;

namespace GenericClassExample
{
    //Declare Generics 
    public class GenericClass<T>
    {
        public void GenFunction(T printvalue)
        {
            Console.WriteLine(printvalue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing Integer Value");
            GenericClass<int> gen = new GenericClass<int>();
            gen.GenFunction(304);

            Console.WriteLine("Printing String Value");
            GenericClass<string> genstring = new GenericClass<string>();
            genstring.GenFunction("Hello.... and Welcome.....");
            Console.ReadKey();
        }
    }
}
