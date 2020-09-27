using System;
using System.Collections.Generic;

namespace GenericSortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> studentlist = new SortedList<int, string>();
            //Adding some items to sorted list
            studentlist.Add(1, "Akshata");
            studentlist.Add(2, "Rahul");
            studentlist.Add(3, "Nivedita");
            studentlist.Add(4, "Rajshree");
            studentlist.Add(5, "Amit");

            //Showing items
            for (int i = 0; i < studentlist.Count; i++)
            {
                Console.WriteLine("Keys : " + studentlist.Keys[i] + "\tValues : " + studentlist.Values[i]);
            }
            Console.WriteLine(" ");
            //Try to Insert Duplicate Keys
            try
            {
                studentlist.Add(5, "Nikita");
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine("This key already exist. " + ex.ToString());
            }
            Console.WriteLine(" ");
            //Change Keys Values
            studentlist[4] = "Ansh";

            Console.WriteLine(" ");
            //Search a Values
            if (studentlist.ContainsValue("Rahul"))
            {
                Console.WriteLine("Items Found at Position : " + studentlist.IndexOfValue("Rahul"));
            }
            Console.WriteLine(" ");

            //Traverse using foreach
            foreach (KeyValuePair<int, string> k in studentlist)
            {
                Console.WriteLine("Key : {0} - Value : {1}", k.Key, k.Value);
            }
            Console.WriteLine(" ");

            //Get the length of SortedList
            int len = studentlist.Count;
            Console.WriteLine("Length of StudentList is {0}", len.ToString());
            Console.ReadKey();
        }
    }
}
