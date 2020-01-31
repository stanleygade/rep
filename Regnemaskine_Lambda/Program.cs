using System;
using System.Collections.Generic;

namespace Regnemaskine_Lambda
{
    class Program
    {
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b; }
        public static int Divider(int a, int b) { return a / b; }
        public static int Gange(int a, int b) { return a * b; }

        static bool Find(int a) { return a < 10; }

        //Predicate<int> FindIndex = x => x == 51;

        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            foreach (var item in a)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            a.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            Console.WriteLine("\r\nFindIndex 51:_________________________");
            Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            Console.WriteLine(a.FindIndex(i => i == 51));

            Console.WriteLine("Plus2:_________________________");
            Func<int, int, int> Plus2 = (a, b) => a + b;
            Console.WriteLine(Plus2(3, 4));


            Console.WriteLine("d:_________________________");
            Func<int, bool> d;
            //d = (int a) => { return a < 10 };
            //d = a => { return a < 10 };
            d = a => a < 10;

            Action<int, bool, string> d2;
            d2 = (a, b, c) =>
            {
                Console.Write(a + " ");
                Console.Write(b + " ");
                Console.Write(c + "\r\n");
            };


            d2(4, false, "hh");

            Console.WriteLine(d(9));
            Console.WriteLine(Find(9));

            /*
                        Func<int,int> Fib = i =>
                        {
                            if (i < 2)  return i; 
                            return Fib(i - 1) + Fib(i - 2); 
                        };
              */
        }
    }
}
