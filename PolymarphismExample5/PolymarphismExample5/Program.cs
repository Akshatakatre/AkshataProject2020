using System;

namespace PolymarphismExample5
{
    class Animal   
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat : Animal   
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: mewo mewo");
        }
    }

    class Dog : Animal   
    {
        public override void animalSound()
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

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
            Console.ReadKey();
        }
    }
}
