using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class FlipCoin
    {
        public void CoinToss()
        {
            int n;
            double head = 0, tail = 0;
            Console.WriteLine("Enter a positive number till you want to flip the coin");
            n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("the number you entered is:" + n);
            for (int flip = 0; flip < n; flip++)
            {
                double coinValue = random.NextDouble();
                if (coinValue < 0.5)
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    head++;
                }
            }
            Console.WriteLine("number of times head you got is:" + head);
            Console.WriteLine("number of times tail you got is:" + tail);
            //percentage
            double perHead = (head / n) * 100;
            double perTail = (tail / n) * 100;
            Console.WriteLine("Percentage of Head vs Tails:" + perHead + " % " + "  " + perTail + " % ");
        }
    }
}
