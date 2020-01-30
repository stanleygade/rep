using System;

namespace opg_120_2_delegates_regnemaskine
{
    public delegate int Beregn(int a, int b);
    class Program
    {
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b; }
        public static int Divider(int a, int b) { return a / b; }
        public static int Gange(int a, int b) { return a * b; }

        public static int Beregner(int a, int b, Beregn metode)
        {
            return metode.Invoke(a, b);

        }


        static void Main(string[] args)
        {
            Beregn b = new Beregn(Plus);
            Console.WriteLine(Beregner(5,4,b));

            int res = b.Invoke(4, 5);
            Console.WriteLine(res);

        }
    }
}
