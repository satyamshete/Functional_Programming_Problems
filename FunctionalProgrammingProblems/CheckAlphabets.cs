using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class CheckAlphabets
    {
        internal void CheckVowel()
        {
            Console.WriteLine("C# Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("Enter Alphabate in small case");
            char a = char.Parse(Console.ReadLine());
            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Alphabate is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabate is Consonant");
                    break;


            }
        }
    }
}
