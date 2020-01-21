using System;

namespace Yatzee
{
    internal class Dice 
    {
        private int eyes;
        private static System.Random rnd = new System.Random();

        public Dice() 
        {
            this.eyes = rnd.Next(1, 7);
        }

        public Dice(int initVal)
        {
            if (initVal >= 1  && initVal <= 6 )
                this.eyes = initVal;

        }

        public void ShowDice()
        {
            Console.Write($"[{eyes}]");
        }

        public void ShakeDice()
        {
            this.eyes = rnd.Next(1, 7); 
        }
    }

    internal class Cup
    {
        private Dice[] cup;

        public Cup()
        {
            this.cup = new Dice[5];
            for (int i = 0; i < 5; i++)
            {
                cup[i] = new Dice();
            }
        }

        public Cup(int numDices) 
        {
            if (numDices > 0 && numDices < 7)
                this.cup = new Dice[numDices];
            for (int i = 0; i < cup.Length; i++)
            {
                cup[i] = new Dice();
            }
        }

        public void showCup()
        {
            for (int i = 0; i < cup.Length; i++)
            {
                cup[i].ShowDice();
            }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            Dice d = new Dice();
            d.ShowDice();
            for (int i = 0; i < 10; i++)
            {
                d.ShakeDice();
                d.ShowDice();
            }
            */
                   
            Cup c = new Cup(6);
            c.showCup();

        }
    }
}
