using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            List<int> liste = new List<int>();
            liste.Add(1);
            liste.Add(2);
            liste.Add(3);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "et");
            dict.Add(2, "to");
            dict.Add(3, "tre");


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine(FindString(2, dict));

            */

            Stack<int> ErId = new Stack<int>();
            ErId.Push(1);
            ErId.Push(2);
            ErId.Push(3);
            
            foreach (var item in ErId)
            {
                Console.WriteLine(item);
            }
            /*
            Console.WriteLine(ErId.Count);
            Console.WriteLine($"Næste element på stakken: {ErId.Peek()}");
            ErId.Pop();
            Console.WriteLine($"Antal ellementer på stakken: {ErId.Count}");
            Console.WriteLine($"Næste element på stakken: {ErId.Peek()}");
            */
            int j = ErId.Count;
            for (int i = 0; i <= j; i++)
            {
                Console.WriteLine($"Antal ellementer på stakken: {ErId.Count}");
                Console.WriteLine($"Næste element på stakken: {ErId.Peek()}");
                ErId.Pop();
            }                       

        }

        static public string FindString(int idx, Dictionary<int,string> dict)
        {
            return dict[idx];
        }
    }
}
