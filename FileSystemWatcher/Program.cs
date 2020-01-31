using System;

namespace FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher(@"c:\work", "*.txt");
            fsw.EnableRaisingEvents = true;

            fsw.Created += Fsw_Created;
            fsw.Changed += (s, e) => Console.WriteLine("Fil ændret: " + e.FullPath + e.ChangeType );
            fsw.Deleted += (s, e) => Console.WriteLine("Fil slettet: " + e.FullPath);
            for (; ; ) { }
            
            /*
            Hund h = new Hund();
            h.Sulten += () => Console.WriteLine("Hundesulten!");
            h.Spis(10);
            h.Spis(50);*/
        }


        private static void Fsw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil oprettet: " + e.FullPath);
        }
    }
    /*class Hund {
        public Action Sulten;
        public int Energi { get; set; } = 100;

        public void Spis(int v)
        {
            Energi -= v;
            if (Energi < 50) { Sulten?.Invoke(); }
        }
    }*/
}
