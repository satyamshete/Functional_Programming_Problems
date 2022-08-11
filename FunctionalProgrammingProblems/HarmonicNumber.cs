using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class HarmonicNumber
    {
        internal void HarmonicCalculator()
        {
            Console.WriteLine("Harmonic Number");
            Console.WriteLine("Enter an number");
            float Count = 0;
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("please enter value greater than zero");
                n = int.Parse(Console.ReadLine());

            }
            while (n >= 1)
            {
                Count = Count + 1 / (float)n;
                n--;

            }
            Console.WriteLine("Outpt of harmmonic is: " + Count);
        }
    }
}
