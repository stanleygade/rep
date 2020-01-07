using System;

namespace Leg1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime dt = System.DateTime.Now;
            DateTime dt2, dt3;
            Console.WriteLine($"dt - Systemtid : {dt}");
            dt = dt.AddDays(10);
            Console.WriteLine($"dt: {dt}");
            dt = dt.AddMinutes(20);
            Console.WriteLine($"dt: {dt}");
            dt = dt.AddMonths(-1);
            Console.WriteLine($"dt: {dt}");
            */
            DateTime start = new DateTime(2020, 01, 07, 9, 0, 0);
            DateTime nu = DateTime.Now;
            DateTime slut = new DateTime(2020, 01, 07, 16, 0, 0);
            Console.WriteLine($"{start} - start");
            Console.WriteLine($"{nu} - nu");
            Console.WriteLine($"{slut} - slut");
            TimeSpan t1, t2;
            System.Threading.Thread.Sleep(5000);
            for (;;)
            {
                Console.Clear();
                nu = DateTime.Now;
                t1 = nu.Subtract(start);
                t2 = slut.Subtract(nu);
                Console.WriteLine($"{t1.ToString()}    - tid gået");
                Console.WriteLine($"{t2.ToString()}    - tid tilbage");
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
