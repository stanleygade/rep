using System;

namespace Opg_100_1_Simpel_Polymorfi
{

    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Fakturanummer: {Nr}    Kunde: {Kunde}      Dato: {Dato}";
        }
    }


    public class Terning
    {
        private static System.Random rnd;
        private int værdi;
        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                //Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }


        public void Ryst()

        {
            this.Værdi = rnd.Next(1, 7);
        }



        public Terning()

        {
            this.Ryst();
        }

        public Terning(int værdi)

        {
            this.Værdi = værdi;
        }

        static Terning() { rnd = new Random(); }
    }
    class LudoTerning : Terning
    {
        public LudoTerning() { }
        public LudoTerning(int værdi) { this.Værdi = værdi; }
        public bool ErGlobus() { return this.Værdi == 3; }
        public bool ErStjerne() { return this.Værdi == 5; }
        public override void Skriv()
        {
            if (ErGlobus()) { Console.WriteLine("[G]"); return; }
            if (ErStjerne()) { Console.WriteLine("[S]"); return; }
            Console.WriteLine($"[{Værdi}]");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura { Kunde = "Tekn.Inst.", Dato = System.DateTime.Now, Nr = 145232 };
            Console.WriteLine(f.ToString());

            Terning t = new Terning();
            t.Skriv();

            LudoTerning lt = new LudoTerning();
            lt.Skriv();

            LudoTerning lt2 = new LudoTerning(3);
            lt2.Skriv();
            Console.WriteLine(lt2.ErGlobus());
            Console.WriteLine(lt2.ErStjerne());

            for (int i = 0; i < 50; i++)
            {
                lt.Ryst();
                lt.Skriv();
            }

        }
    }
}
