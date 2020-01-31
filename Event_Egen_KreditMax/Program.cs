using System;

namespace Event_Egen_KreditMax
{


    public class Kunde
    {
        // event mangler
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {/*
                if (KreditOverskredet != null)
                KreditOverskredet(this, new EventArgs());
                */
                KreditOverskredet?.Invoke(this, new EventArgs());
            }
            
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kunde k = new Kunde() { KreditMax = -500 };

            k.KreditOverskredet += (s, e) =>  Console.WriteLine("Kredit overskredet");

            k.Køb(100);
            k.Køb(400);
            k.Køb(100);


        }
    }
}
