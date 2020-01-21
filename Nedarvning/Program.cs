using System;

namespace Nedarvning
{
    class Person    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        { return Fornavn + " " + Efternavn; }
    }
    class Elev : Person 
    {
        public string Klasselokale { get; set; }
    }

    class Instruktor : Person 
    {
        public int NøgleId { get; set; }

    }

    class UdvidetRandom : Random
    {
        Random r = new System.Random();
        public bool NextBool()
        {
            return (r.Next(1, 1002) < 501);
        }
    }



    
    class Program
    {
        static void Main(string[] args)
        {
            /*        Person p = new Person();
                    p.Fornavn = "Arthur";
                    p.Efternavn = "Jensen";
                    Console.WriteLine(p.FuldtNavn());


                    Elev e = new Elev();
                    e.Fornavn = "Hans";
                    e.Efternavn = "Hansen";
                    Console.WriteLine(e.FuldtNavn());*/
            UdvidetRandom ur = new UdvidetRandom();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ur.NextBool());
            }
            
            


        }
    }
}
