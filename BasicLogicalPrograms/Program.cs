using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Choose 1.FlipCoin 2.LeapYear");
            N = Convert.ToInt32(Console.ReadLine());
            switch (N)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CoinToss();
                    break;
                case 2:
                    CheckLeapYear checkLeapYear = new CheckLeapYear();
                    checkLeapYear.CheckLeapYr();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
