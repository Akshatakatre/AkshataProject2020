using System;
using System.Collections.Generic;

namespace GenericDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Generic Collection
            Dictionary<string, string> movie = new Dictionary<string, string>();

            //Adding Item in Collection
            movie.Add("sci-fi", "Star Wars");
            movie.Add("Action", "The One");
            movie.Add("Fantacy", "Star Dust");
            movie.Add("Computer", "Algorithm");
            movie.Add("Horror", "Anabella");

            //Printing single item
            Console.WriteLine(movie["sci-fi"]);

            //Iterate Dictionary
            foreach (KeyValuePair<string, string> items in movie)
            {
                Console.WriteLine(items.ToString());
            }

            //Find items
            if (movie.ContainsKey("sci-fi"))
            {
                Console.WriteLine("Key found. Value is " + movie["sci-fi"]);
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
            Console.ReadKey();

        }
    }
}
