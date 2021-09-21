using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo 4.HarmonicNumber");
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
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.PowerOfTwoTable();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.PrintHarmonicNum();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
