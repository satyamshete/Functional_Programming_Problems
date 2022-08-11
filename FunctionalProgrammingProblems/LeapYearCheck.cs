using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class LeapYearCheck
    {
        internal void CheckLeapYear()
        {
            Console.WriteLine("Leap Year Programme");
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            while (year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter 4 digit value");
                year = int.Parse(Console.ReadLine());
            }
            if (year % 100 == 0 && year % 400 == 0)
            {


                Console.WriteLine("Given Year is Leap Year ");

            }
            else
            {
                if (year % 100 != 0 && year % 4 == 0)
                {
                    Console.WriteLine("Given Year is Leap Year ");
                }
                else
                {
                    Console.WriteLine("Given Year isnot a Leap Year ");

                }
            }





        }
    }
}

