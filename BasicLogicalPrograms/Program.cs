﻿using System;

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
                try
                {
                    Console.WriteLine("Choose 1.FlipCoin 2.CheckleapYear 3.PowerOfTwo 4.HarmonicNumber 5.PrimeFactors 6.QuotientandRemainder 7.SwapOfTwoNumbers 8:CheckEvenOrOdd 9.CheckVowelOrConsonat 10.LargestAmongThreeNumbers");
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
                        case 7:
                            SwapOfTwoNumbers swapOfTwoNumbers = new SwapOfTwoNumbers();
                            swapOfTwoNumbers.SwapOfNum(3, 4);
                            break;
                        case 8:
                            CheckEvenOrOdd checkEvenOrOdd = new CheckEvenOrOdd();
                            checkEvenOrOdd.CheckEvenOrOddNum();
                            break;
                        case 9:
                            CheckVowelOrConsonant checkVowelOrConsonant = new CheckVowelOrConsonant();
                            checkVowelOrConsonant.IsVowelOrConsonant();
                            break;
                        case 10:
                            LargestAmongThreeNumbers largestAmongThreeNumbers = new LargestAmongThreeNumbers();
                            largestAmongThreeNumbers.LargestNumber(3, 4, 5);
                            break;
                        default:
                            Console.WriteLine("Choose valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a valid Option");

                }
            }
        }
    }
}
