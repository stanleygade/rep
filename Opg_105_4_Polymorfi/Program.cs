using System;
using System.Collections.Generic;

namespace Opg_105_4_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund() { Navn = "Otto" };
            Kat k = new Kat() { Navn = "Kisser" };
            List<Dyr> Dyrene = new List<Dyr>();
            Dyrene.Add(h);
            Dyrene.Add(k);
                    
            foreach (Dyr item in Dyrene)
            {
                item.SigNoget();
            }

        }
    }

    class Dyr 
    {
        public string Navn { get; set; }

        virtual public void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }
    }

    class Hund : Dyr
    {
        override public void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }

    class Kat : Dyr 
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }
}
