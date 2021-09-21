using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo 4.HarmonicNumber 5.PrimeFactor");
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
                case 6:
                    QuotientandRemainder quotientandRemainder = new QuotientandRemainder();
                    quotientandRemainder.CompQuotientandRemainder(40, 5);
                    break;
                case 7:
                    SwapOfTwoNumbers swapOfTwoNumbers = new SwapOfTwoNumbers();
                    swapOfTwoNumbers.SwapOfNum(3, 4);
                    break;
                case 8:
                    CheckEvenOrOdd checkEvenOrOdd = new CheckEvenOrOdd();
                    checkEvenOrOdd.CheckEvenOrOddNum();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
