using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class TwoPower
    {
        internal void PowerOfTwo()
        {
            Console.WriteLine("Power of 2");
            Console.WriteLine("Enter an number from zero to 31");
            int count = 1;
            int N = int.Parse(Console.ReadLine());
            while (N < 0 || N > 31)
            {
                Console.WriteLine("please enter value from 0 t0 31");
                N = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= N; i++)
            {
                count = count * 2;
            }
            Console.WriteLine("value of 2 to power {0} is: {1}", N, count);
        }
    }
}
