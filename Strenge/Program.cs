using System;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletstreng = fornavn + " " + efternavn;
            Console.WriteLine(samletstreng);
            string lilleNavn = samletstreng.ToLower();
            Console.WriteLine(lilleNavn);
            string stortNavn = samletstreng.ToUpper();
            Console.WriteLine(stortNavn);
            Console.WriteLine(efternavn.Substring(0, 4));
            string path = "c:\\test\\test.txt";
         try {
                System.IO.File.WriteAllText(path, stortNavn);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            }
    }
}
