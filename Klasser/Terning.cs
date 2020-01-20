using System;

namespace Klasser
{
    internal class Terning 
    {
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();

        ublic Terning()
        {
            snyd = false;
            værdi = 1;
        }

        /*        public Terning(int StartVærdi)
                {
                    if (StartVærdi < 1 || StartVærdi > 6)
                        throw new Exception("Værdi skal være mellem 1 og 6");
                    værdi = StartVærdi;
                }
          */

        public Terning(bool snyd) 
        {
            this.snyd = snyd;
        }

        public void Skriv()
        {
            Console.WriteLine($"Værdi: {værdi}");
        }

        public void Ryst()
        {
            if (snyd == true)
            { værdi = 6; }
            else 
            { værdi = rnd.Next(1, 7); }
        }



        public void VisVærdi() 
        {
            System.Console.WriteLine(værdi);
        }

        public int HentVærdi() {
            return 0;
        }

        public void SætVærdi(int a)        { }
        /*
        public void Ryst()
        {
            System.Random
        }
        */
    }
}
