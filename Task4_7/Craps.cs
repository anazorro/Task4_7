using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_7
{
    class Craps
    {
        Dice dice1;
        Dice dice2 = new Dice();

        int value1;
        int value2;
        int total;

        public void Play()
        {
            Thread.Sleep(300);
            dice1 = new Dice();

            bool finished = false;
            while (!finished)
            {
                value1 = dice1.Throw();
                value2 = dice2.Throw();

                ShowDice();

                finished = CheckScore();
            }

        }

        private bool CheckScore()
        {
            switch (total)
            {
                case 2:
                case 3:
                case 12:
                    Console.WriteLine("You loose!!!");
                    return true;

                case 7:
                case 11:
                    Console.WriteLine("You Win!!!");
                    return true;

                default:
                    Console.WriteLine("You get a point!");
                    return false;

            }
        }

        public void ShowDice()
        {
            Console.WriteLine(" Dice 1 = " + value1);
            Console.WriteLine(" Dice 2 = " + value2);

            total = value2 + value1;
            Console.WriteLine("Total = " + total);
        }
    }
}
