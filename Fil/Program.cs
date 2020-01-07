using System;

namespace Fil
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\test\temp.txt";
            string text = "Der var engang en mand, der boede i en spand.";

            SkrivFil(path, text);
            LæsFil(path);
            //System.IO.File.Create(path);
            
         /*
            string indhold = System.IO.File.ReadAllText(@"c:\test\test.txt");

            System.IO.FileInfo f = new System.IO.FileInfo(@"c:\test\test.txt");

            Console.WriteLine(indhold);
            Console.WriteLine(f.FullName);
            */
        }

        static void LæsFil(string path)
        {
            System.IO.FileInfo fil = new System.IO.FileInfo(path);
            if (fil.Exists)
            {
                Console.WriteLine(fil.LastAccessTime);
                Console.WriteLine(fil.Extension);
            }
            }

        static void SkrivFil(string path, string text)
        {
            System.IO.File.WriteAllText(path, text);
        }

    }
}
