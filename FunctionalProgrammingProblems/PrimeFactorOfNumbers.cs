using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class PrimeFactorOfNumbers
    {
        internal void PrimeFactor()
        {
            Console.WriteLine("Factors");
            Console.WriteLine("Enter Number");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1 / 2; i++)
            {
                int Count = 0;
                if (n1 % i == 0)
                {
                    for (int j = 1; j <= i / 2; j++)
                    {


                        if (i % j == 0)
                        {
                            Count = Count + 1;
                        }
                    }
                    if (Count == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
