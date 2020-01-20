using System;

namespace Beregninger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Beregninger.LægSammen(1, 9));

            Beregninger b = new Beregninger();
            
            b.VisVærdier();
            b.GemVærdier(1, 5);
            b.VisVærdier();
            Console.WriteLine(b.Adder());
            b.VisVærdier();

        }
    }

    public class Beregninger
    {
        private int a;
        private int b;

        public Beregninger()
        {
            a = 0;
            b = 0;
        }

        public static int LægSammen(int a, int b)
        { return a + b; }

        public static int TrækFra(int a, int b)
        { return a - b; }

        public int Adder()
        {
            return a + b;
        }
        public void VisVærdier()
        {
            Console.WriteLine($"a: {a} b: {b}") ;
        }

        public void GemVærdier(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
    }
}
