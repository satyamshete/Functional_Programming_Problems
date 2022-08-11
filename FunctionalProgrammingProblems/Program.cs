﻿namespace FunctionalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your selection from below");
            Console.WriteLine("1. Flip Coin Percentage");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of Two");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Prime Factors");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    PercentageCoinFlip percentageCoinFlip = new PercentageCoinFlip();
                    percentageCoinFlip.FlipCoinPercentage();
                    Console.WriteLine();
                    break;
                case 2:
                    LeapYearCheck leapYearCheck = new LeapYearCheck();
                    leapYearCheck.CheckLeapYear();
                    Console.WriteLine();
                    break;
                case 3:
                    TwoPower twoPower = new TwoPower();
                    twoPower.PowerOfTwo();
                    Console.WriteLine();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicCalculator();
                    Console.WriteLine();
                    break;
                case 5:
                    PrimeFactorOfNumbers primeFactorOfNumbers = new PrimeFactorOfNumbers();
                    primeFactorOfNumbers.PrimeFactor();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
        }
    }
}