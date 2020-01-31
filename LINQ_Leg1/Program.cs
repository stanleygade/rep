using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Leg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 67, 8, 545, 4, 5, 89, 4356, 56, 345, 6564, 5, 1, 121 };

            // query syntaks
            var s1 = from x in a where x < 10 orderby x select x;
            // method synaks
            var s2 = a.Where(x => x < 10).OrderBy(x => x);
            /*
            foreach (var item in s1)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            foreach (var item in s2)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            */
            /*
            var mappe = new System.IO.DirectoryInfo(@"c:\work");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Har fundet {filer.Length} i {mappe.Name}");

            var res = filer.Where(i => i.Length > 100);
            */
            Console.WriteLine(string.Join(' ', a));

            var opgave1501a = a.Count();
            Console.WriteLine("Count " + opgave1501a);

            var opgave1501b = a.Count(x => x > 7);
            Console.WriteLine("Count > 7 " + opgave1501b);

            var opgave1501c = a.Sum();
            Console.WriteLine("Sum " + opgave1501c);

            var opgave1501d = a.Average();
            Console.WriteLine("Average " + opgave1501d);

            Console.WriteLine(string.Join(' ', a.OrderBy(a => a)));

            Console.WriteLine(string.Join(' ', a.Where(a => a > 5)));

            Console.WriteLine(string.Join(' ', a.Take(5)));
            Console.WriteLine(string.Join(' ', a.Skip(5).Take(5)));

        }
    }
}
