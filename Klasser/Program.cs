using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terning1 ");
            Terning t = new Terning();
     
            t.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t.Ryst();
                t.Skriv();
            }

            Console.WriteLine("Terning2 ");
            Terning t2 = new Terning(true);

            t2.Skriv();
            for (int i = 0; i < 3; i++)
            {
                t2.Ryst();
                t2.Skriv();
            }

        }
    }
}
