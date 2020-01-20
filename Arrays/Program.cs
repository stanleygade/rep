using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] månedsløn = { 20_000, 25_000, 50_000, 66_000, 42_000 };
            int løn = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                løn += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }
            double gnsløn = (double)løn / (double)månedsløn.Length;

            Console.WriteLine("\n");
            Console.WriteLine(gnsløn);
                       
            System.Array.Sort(månedsløn);
            Console.WriteLine("\n");

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i] + " ");
            }
            */
            string [,] ole = new string[4, 2];
            ole[0, 0] = "1";
            ole[1, 0] = "2";
            ole[2, 0] = "3";
            ole[3, 0] = "4";
            ole[0, 1] = "n1";
            ole[1, 1] = "n2";
            ole[2, 1] = "n3";
            ole[3, 1] = "n4";
            /*
            foreach (var item in ole)
            {
                Console.WriteLine(item);
            }            
            */
            PrintArray(ole);
            //Console.WriteLine(ole);




        }
        static public void PrintArray(string[,] hat)
        {
            for (int i = 0; i < hat.GetLength(0); i++)
            {
                for (int j = 0; j < hat.GetLength(1); j++)
                {
                    Console.Write(hat[i,j] + " ");
                    if(j == hat.GetLength(1)-1)
                    { Console.WriteLine(""); }
                }
            } 
        }
    }
}
