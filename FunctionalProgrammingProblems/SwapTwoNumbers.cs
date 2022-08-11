using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class SwapTwoNumbers
    {
        internal void SwapNumbers()
        {
            Console.WriteLine("C# Program to Swap Two Numbers");
            Console.WriteLine("Enter value of first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of second number");
            int b = int.Parse(Console.ReadLine());
            (a, b) = SwapTwoNumber(a, b);
            Console.WriteLine("value of first and second number are: {0} {1} ", a, b);
        }
        private (int, int) SwapTwoNumber(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            return (a, b);
        }
    }
}
