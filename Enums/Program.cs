using System;

enum KortKulør
{
    Spar = 1
          , Hjerter = 2
          , Ruder = 3
          , Klør = 4
}


namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {


            /*KortKulør kort1 = KortKulør.Klør;
            
            Console.WriteLine(Convert.ToInt32(kort1));
            Console.WriteLine(kort1);
            */

            Console.WriteLine("Indtast kulør (1-4)");
            int q = 0;
            string tal = Console.ReadLine();

            try { q = int.Parse(tal);
                KortKulør kortx = (KortKulør)q;

                switch (kortx)
                {
                    case KortKulør.Spar:
                        Console.WriteLine(KortKulør.Spar);
                        break;
                    case KortKulør.Hjerter:
                        Console.WriteLine(KortKulør.Hjerter);
                        break;
                    case KortKulør.Ruder:
                        Console.WriteLine(KortKulør.Ruder);
                        break;
                    case KortKulør.Klør:
                        Console.WriteLine(KortKulør.Klør);
                        break;
                    default:
                        Console.WriteLine("Tallet er ikke mellem 1 og 4");
                        break;
                }
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }




        }
    }
}

