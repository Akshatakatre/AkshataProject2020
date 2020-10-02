using System;

namespace InterfaceExample4
{
    interface I1st
    {

        void rank();

    }

    interface I2nd
    {

        void rank();

    }

    class Position : I1st, I2nd
    {

        void I1st.rank()
        {
            Console.WriteLine("Rank 1st");
        }

        void I2nd.rank()
        {
            Console.WriteLine("Rank 2nd");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            I1st p = new Position();
            p.rank();
            Console.ReadKey();
            
        }
    }
}
