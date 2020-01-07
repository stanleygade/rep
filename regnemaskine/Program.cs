using System;

namespace regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1!");
            string tal1 = Console.ReadLine();
            try
            {
                Double.Parse(tal1);
                Console.WriteLine($"Tal 1: {tal1}");
            }
            catch
            {
                Console.WriteLine($"Tal 1 kan ikke parses: {tal1}");
            }

            Console.WriteLine("Indtast tal 2!");
            string tal2 = Console.ReadLine();
            try
            {
                Double.Parse(tal2);
                Console.WriteLine($"Tal 2: {tal2}");
            }
            catch
            {
                Console.WriteLine($"Tal 2 kan ikke parses: {tal2}");
            }


            double res = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
            Console.WriteLine($"Resultat: {res.ToString("N2")}");


        }
    }
}
