using System;

namespace BasicLogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool IsExitProgram = false;
            try
            {
                while (!IsExitProgram)
                {
                    Console.WriteLine("Choose 1.FlipCoin 2.LeapYear");
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
                        default:
                            IsExitProgram = true;
                            Console.WriteLine("Choose valid option");
                            break;
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Choose a valid option");
            }
        }
    }
}
