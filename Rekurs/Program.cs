using System;

namespace Rekurs
{
    class Program
    {
        private const int X = 20;

        static void Main(string[] args)
        {
            Console.WriteLine(fib(X).ToString());
        }

        public static int fib(int x)
        {
            if (x < 2) { return x; }
            else { return fib(x - 1) + fib(x - 2); }
        }
    }
}
