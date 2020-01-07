using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "";

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i * j <= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write((i * j).ToString().PadLeft(4));
                    //    t = t + (i * j).ToString().PadLeft(4);

                }

                //t = t + "\r\n";
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\r\n");

            }

            for (int k = 0; k < 19; k++)
            {
                if (k <= 15)
                {
                    if (k % 3 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(k);
                    }
                }
                else
                {
                    break;
                }
            }


            //Console.WriteLine(t);
        }
    }
}
