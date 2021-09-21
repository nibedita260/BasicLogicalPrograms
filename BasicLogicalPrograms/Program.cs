using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo");
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
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
