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
                Console.WriteLine("Choose 1.FlipCoin");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.CoinToss();
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
