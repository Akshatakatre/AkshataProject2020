using System;

namespace InterfaceExample6
{
    interface IAnimal
    {
        void animalSound(); 
    }

    class Cat : IAnimal
    {
        public void animalSound()
        {
            
            Console.WriteLine("The cat says: meow... meow...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();  
            myCat.animalSound();
            Console.ReadKey();
        }
    }
}
