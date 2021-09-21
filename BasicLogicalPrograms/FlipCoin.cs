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
            int head = 0, tail = 0;
            Console.WriteLine("Enter a positive number till you want to flip the coin");
            N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double coinValue = random.NextDouble();
            Console.WriteLine("the number you entered is:" + N);
            for(int flip=0;flip<N;flip++)
            {
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
            Console.WriteLine("Number of times head you got is:" + head);
            Console.WriteLine("Number of times tail you got is:" + tail);
            //percentage
            double perHead = (double)head / N * 100;
            double perTail = (double)tail / N * 100;
            Console.WriteLine("Percentage of Head vs Tails:" + perHead + "%" + perTail+"%");
        }
    }
}
