using System;

namespace indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "x";
            System.Console.WriteLine(p.Navn);
        }
    }

    class Person
    {
        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
            //set { Navn = value; }
        }
    }
}