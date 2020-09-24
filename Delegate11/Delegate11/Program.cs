using System;

namespace Delegate11
{
    public delegate void OnFiveHandler(object sender, EventArgs e);

    class FEvent
    {
        public event OnFiveHandler FiveEvent;

        public void OnFiveEvent()
        {
            if (FiveEvent != null)
            {
                FiveEvent(this, EventArgs.Empty);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fe = new FEvent();
            fe.FiveEvent += new OnFiveHandler(Callback);

            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int rn = random.Next(6);

                Console.WriteLine(rn);

                if (rn == 5)
                {
                    fe.OnFiveEvent();
                }
            }
            Console.ReadKey();
        }

        public static void Callback(object sender, EventArgs e)
        {
            Console.WriteLine("Five Event occurred");
        }
    }
    
}
