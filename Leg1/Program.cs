using System;

namespace Leg1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = System.DateTime.Now;
            DateTime dt2, dt3;
            Console.WriteLine($"dt - Systemtid : {dt}");
            dt = dt.AddDays(10);
            Console.WriteLine($"dt: {dt}");
            dt = dt.AddMinutes(20);
            Console.WriteLine($"dt: {dt}");
            dt = dt.AddMonths(-1);
            Console.WriteLine($"dt: {dt}");
            DateTime dt4 = new DateTime(1972, 12, 2, 12, 2, 1);
            Console.WriteLine($"dt4: {dt4}");

        }
    }
}
