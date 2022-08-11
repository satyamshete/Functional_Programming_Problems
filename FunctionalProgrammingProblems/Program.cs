namespace FunctionalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your selection from below");
            Console.WriteLine("1. Flip Coin Percentage");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    PercentageCoinFlip percentageCoinFlip = new PercentageCoinFlip();
                    percentageCoinFlip.FlipCoinPercentage();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
        }
    }
}