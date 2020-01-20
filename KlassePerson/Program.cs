using System;

namespace KlassePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"Fuldt navn: {p1.FuldtNavn()}");
            Person p2 = new Person { Fornavn = "Kranen", Efternavn = "Karen", Fødselsår = 1967 };
            Console.WriteLine($"Fuldt navn: {p2.FuldtNavn()}");
            Console.WriteLine($"{p2.Fornavn}s alder: {p2.Alder()}");
        }
    }
    class Person 
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;


        public Person()
        {
            Fornavn = "";
            Efternavn = "";
        }

        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Fødselsår = Fødselsår;
                }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            DateTime nu =  System.DateTime.Now;
            return nu.Year - Fødselsår;
        }

    }

}
