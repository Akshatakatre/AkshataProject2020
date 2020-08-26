using System;

namespace LambdaAss1
{
     class User
    {
        public int userid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string role { get; set; }
    }
    class Program
    {
         delegate void Userdel(User u);
        static void Main(string[] args)
        {
           
           Userdel ud=d =>
            {
                Console.WriteLine("user id is " + d.userid);
                Console.WriteLine("first name is  " + d.firstname);
                Console.WriteLine("last name is " + d.lastname);
                Console.WriteLine("role is " + d.role);

            };
            Console.WriteLine("enter the user id");
             int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first name");
            string fn = Console.ReadLine();
            Console.WriteLine("enter last name");
            string ln = Console.ReadLine();
            Console.WriteLine("enter the role");
            string r = Console.ReadLine();
            User us = new User() { userid = id, firstname = fn, lastname = ln, role = r };
            ud(us);
            Console.ReadKey();

        }
    }
}
