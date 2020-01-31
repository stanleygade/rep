using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Console.WriteLine("Hello World!");
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 500;
            t.Enabled = true;
            /*            t.Elapsed += T_Elapsed;*/
            t.Elapsed += (s, e) => Console.WriteLine("Tick " + e.SignalTime);
            t.Start();
            Console.ReadKey();
        }

        private static void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Tick");
        }
    }
}
