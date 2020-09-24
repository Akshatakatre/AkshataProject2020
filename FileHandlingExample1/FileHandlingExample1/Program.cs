﻿using System;
using System.IO;

namespace FileHandlingExample1
{
    class Program
    {
        class ReadFile
        {

            public void DataReading()
            {
                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr = new StreamReader("E://practice.txt");

                Console.WriteLine("Content of the File");

                // This is use to specify from where  
                // to start reading input stream 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str = sr.ReadLine();

                // To read the whole file line by line 
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();

                // to close the stream 
                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            ReadFile wr = new ReadFile();
            wr.DataReading();
            Console.ReadKey();
        }
    }
}
