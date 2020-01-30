using System;

namespace Opg_110_1_Interface
{
    interface IDbFunktioner
    {
        void Gem() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund() { Navn = "Oskar" };
            h.Gem();
            Ubåd u = new Ubåd() { Tubine = 2, Nummer = 596 };
            u.Gem();
            IDbFunktioner[] dimser = new IDbFunktioner[5];
            dimser[0] = new Hund() { Navn = "Fido" };
            dimser[1] = new Ubåd() { Tubine = 3.001, Nummer = 443};
            dimser[2] = new Ubåd() { Tubine = -.993, Nummer = 21 };
            dimser[3] = new Hund() { Navn = "Otto" };
            dimser[4] = new Hund() { Navn = "Walther" };

            foreach (var item in dimser)
            {
                item.Gem();
            }
        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem() { Console.WriteLine($"Gemmer hunden {Navn}"); }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem() { Console.WriteLine($"Gemmer ubåden med nummer {Nummer.ToString()}, som har {Tubine.ToString()} turbiner"); }
    }
}
