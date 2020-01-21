using System;

namespace Opg_90._1___Full_Property
{


    class Vare
    {
        private string navn;
        private double pris;

        public double Pris
        {
            get { Console.WriteLine($"Pris aflæst for {this.navn}"); return pris; }
            set { Console.WriteLine($"Pris sat for {this.navn}"); pris = value; }
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public Vare() { }
        public Vare(string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;
        }

        public double PrisMedMoms()
        {
            return pris *= 1.25;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Pris = 200;
            Console.WriteLine(v.Pris);
            Console.WriteLine(v.PrisMedMoms());

            Vare w = new Vare("hat", 1_000);
            Console.WriteLine(w.Pris);
            Console.WriteLine(w.PrisMedMoms());

        }
    }
}
