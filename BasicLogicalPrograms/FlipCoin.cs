using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class FlipCoin
    {
        public void CoinToss()
        {
            int N;
            double head = 0, tail = 0;
            double perHead=0, perTail=0;
            Console.WriteLine("Enter a positive number till you want to flip the coin");
            N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double coin = random.NextDouble();
            Console.WriteLine("the number you entered is:" + N);
            while (N > 0)
            {
                if (coin < 0.5)
                {
                    Console.WriteLine("Tails");
                    tail++;
                    //percentage
                    perHead = (head * 100)/100;
                }
                else
                {
                    Console.WriteLine("Heads");
                    head++;
                    //percentage
                    perTail = (tail * 100)/100;
                }
                N--;
            }
            Console.WriteLine("Number of times head you got is:" + head);
            Console.WriteLine("Number of times tail you got is:" + tail);
            Console.WriteLine("Percentage of Head vs Tails:" + perHead + "%" + perTail+"%");
        }
    }
}
