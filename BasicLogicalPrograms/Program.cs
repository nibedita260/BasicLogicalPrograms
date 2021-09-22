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
                Console.WriteLine("Choose 1.FlipCoin 2.LeapYear 3.PowerOfTwo");
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
                    default:
                        IsExitProgram = true;
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}
