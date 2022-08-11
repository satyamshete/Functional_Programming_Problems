using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class EvenOddCheck
    {
        internal void CheckEvanOdd()
        {
            Console.WriteLine("C# Program to Check Whether a Number is Even or Odd");
            Console.WriteLine("Enter value of Number");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Given number {0} is Even", a);
            }
            else
            {
                Console.WriteLine("Given number {0} is Odd", a);
            }
        }
    }
}
