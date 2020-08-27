using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akupperlower
{
    public class upplow
    {
         public string[] Conv(params string[] name)
        {
            int j;
            j = int.Parse(Console.ReadLine());
            for(j=0;name[j]!="\0";j++)
            {
                if(name[j]="A") 
                {
                    name[j] = name[j] - 32;
                }
                else
                    if(name[j] = "Z")
                {
                    
                        name[j] = name[j]-32;
                    
                }
                    Console.WriteLine(name);
            }        
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string n;
            n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the number");
            for(i=0;i="n";i++)
            {
                Console.ReadLine();
            }
            upplow ul = new upplow();
            ul.conv
        }
    }
}
