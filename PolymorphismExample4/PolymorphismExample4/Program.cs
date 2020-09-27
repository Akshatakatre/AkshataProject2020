using System;

namespace PolymorphismExample4
{
    class Animal  
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat : Animal   
    {
        public void animalSound()
        {
            Console.WriteLine("The cat says: Mewo Mewo");
        }
    }

    class Dog : Animal  
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  
            Animal myCat = new Cat(); 
            Animal myDog = new Dog();
            Cat c = new Cat();
            Dog d = new Dog();

            myAnimal.animalSound();
            //myCat.animalSound();
            //myDog.animalSound();
            c.animalSound();
            d.animalSound();
            Console.ReadKey();
        }
    }
}
