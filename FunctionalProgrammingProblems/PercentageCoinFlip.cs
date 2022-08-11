using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class PercentageCoinFlip
    {
        internal void FlipCoinPercentage()
        {
            Console.WriteLine("Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("Enter number of of times Coin needs to flip");
            int Nu = int.Parse(Console.ReadLine());
            while (Nu < 0)
            {
                Console.WriteLine("Enter number greater tahn 0");
                Nu = int.Parse(Console.ReadLine());
            }

            int k = Nu;
            Random random = new Random(1);

            int a = 0, b = 0;
            while (Nu > 0)
            {
                double coinValue = random.NextDouble();
                if (coinValue < 0.5)  ////for tail
                {
                    a++;
                }
                else
                {
                    b++;
                }

                Nu--;

            }
            float p, q;
            p = a / (float)k * 100;
            q = b / (float)k * 100;
            Console.WriteLine("Tail percentage is {0} and head percentage is {1}", p, q);
        }
    }
}
