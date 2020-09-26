using System;

namespace Constructor6
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Black", 1969);
            //Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            Console.WriteLine("Car Name : " + Ford.model);
            Console.WriteLine("Car color : " + Ford.color);
            Console.WriteLine("Car modal year : " + Ford.year);
            Console.ReadKey();
        }
    }
}
