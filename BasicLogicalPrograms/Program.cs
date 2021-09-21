using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo 4.HarmonicNumber 5.PrimeFactors");
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
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.PrintPrimeFactors();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
