using System;
using System.Collections.Generic;

namespace GenericListExample
{
    class Program
    {

        static void Main(string[] args)
        {
            //Adding Item 
            List<string> myList = new List<string>();
            myList.Add("Mango");
            myList.Add("Banana");
            myList.Add("Orange");

            //Printing Item
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Sorting List
            myList.Sort();
            Console.WriteLine("\n After Sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Removing Items
            myList.Remove("Orange");
            Console.WriteLine("\nRemoving Orange");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");

            //Inserting Item in the middle
            myList.Insert(2, "Pineapple");
            Console.WriteLine("\nInserting Pineapple at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            Console.ReadKey();
        }
    }
}
