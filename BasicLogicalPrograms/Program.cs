using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool IsExitProgram = false;
            while (!IsExitProgram)
            {
                Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo 4.HarmonicNumber 5.PrimeFactor 6.QuotientandRemainder");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
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
                    default:
                        IsExitProgram = true;
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}
