using System;

namespace opg_120_1_simpel_delegate
{

    public delegate void MinDelegate1(string tekst);
        
    class Program
    {
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }


        static void Main(string[] args)
        {
            MinSkrivTilConsole("Text");

            MinDelegate1 m1 = new MinDelegate1(MinSkrivTilConsole);
            m1.Invoke("hatten er fin");

            MinDelegate1 m2 = MinSkrivTilConsole;
            m2("frakken er også flot");

            MinDelegate1 m3 = MinSkrivTilConsole;
            m3 += Console.WriteLine;

            m3("bøllehat");

            Console.WriteLine(m3.ToString());

            m1 -= MinSkrivTilConsole;
            m2 -= MinSkrivTilConsole;
            m3 -= MinSkrivTilConsole;
            m3 -= Console.WriteLine;
            /*
            m1 = null;
            m2 = null;
            m3 = null;
            */
        }
    }
}
