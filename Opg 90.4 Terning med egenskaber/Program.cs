using System;

namespace Opg_90._4_Terning_med_egenskaber
{



    class Terning
    {
        private int værdi;
        private Random rnd = new Random();

        public int Værdi
        {
            get { return værdi; }
            set { if (value > 0 && value < 6 ) værdi = value; værdi = 1; }
        }


        public Terning()
        {
            Ryst();
        }

        public Terning(int value)
        {
            this.Værdi = value;
        }

        public void Ryst()
        {
            værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine(Værdi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            Console.WriteLine(t.Værdi);

            Terning t2 = new Terning(6);
            Console.WriteLine(t2.Værdi);

            Terning t3 = new Terning(9);
            Console.WriteLine(t3.Værdi);

        }
    }
}
