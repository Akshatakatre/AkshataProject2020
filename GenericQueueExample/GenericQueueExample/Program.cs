using System;
using System.Collections.Generic;

namespace GenericQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> student = new Queue<string>();

            //Adding item in queue
            student.Enqueue("Akshata");
            student.Enqueue("Rahul");
            student.Enqueue("Nivedita");
            student.Enqueue("Nikita");
            student.Enqueue("Rajshree");
            print(student);

            //Removing Item
            Console.WriteLine("\nRemoving {0} from List. \nNew list is : ", student.Dequeue());
            print(student);

            //Copy Array Item to Queue
            string[] city = { "Nagpur", "Pune", "Mumbai" };
            Queue<string> citylist = new Queue<string>(city);
            Console.WriteLine("\nPrinting City List");
            print(citylist);

            //Count items in Queue
            Console.WriteLine("Count{0}", citylist.Count);
        }
        public static void print(Queue<string> q)
        {
            foreach (string s in q)
            {
                Console.Write(s.ToString() + " | ");
            }
            Console.ReadKey();
        }
    }
}
