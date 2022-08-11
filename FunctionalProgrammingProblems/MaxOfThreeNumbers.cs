using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class MaxOfThreeNumbers
    {
        internal void CheckMaxNumber()
        {
            Console.WriteLine("C# Program to Find the Largest Among Three Numbers");
            Console.WriteLine("Enter value of first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of third Number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum form {0} {1} {2} is {3} ", a, b, c, a > b ? (a > c ? a : c) : (b > c ? b : c));
        }
    }
}
