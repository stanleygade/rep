using System;

namespace Opg_90_6_Automatiske_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person();
            p.Fornavn = "Hans";
            p.Efternavn = "ee";
            Console.WriteLine(p.FuldtNavn());

            Person p1 = new Person();
            p1.Fornavn = "Hans";
            p1.Efternavn = "Hansen";
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.fullname);

        }
    }

    class Person 
    {
        public string Fornavn { get; set; }
        
        private string efternavn;
        
       public string Efternavn
        {
            get { return efternavn; }
            set { if (value.Length > 3) efternavn = value; else efternavn = ""; }
        }

        public string fullname { get { return Fornavn + " " + Efternavn; } }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
