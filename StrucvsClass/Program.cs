using System;

namespace StrucvsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct:");
            Persons k1 = new Persons();
            Persons k2 = new Persons();
            k1.Id = 1;
            k2.Id = 2;
            Console.WriteLine($"K1: {k1.Id}  K2: {k2.Id}");
            k1 = k2;
            Console.WriteLine($"K1: {k1.Id}  K2: {k2.Id}");
            k1.Id = 3;
            Console.WriteLine($"K1: {k1.Id}  K2: {k2.Id}");

            Console.WriteLine("Class:");
            Personc k3 = new Personc();
            Personc k4 = new Personc();
            k3.Id = 1;
            k4.Id = 2;
            Console.WriteLine($"K3: {k3.Id}  K4: {k4.Id}");
            k3 = k4;
            Console.WriteLine($"K3: {k3.Id}  K4: {k4.Id}");
            k3.Id = 3;
            Console.WriteLine($"K3: {k3.Id}  K4: {k4.Id}");

        }
    }

    struct Persons
    {
        public int Id;
    }

    class Personc
    {
        public int Id;
    }
}
