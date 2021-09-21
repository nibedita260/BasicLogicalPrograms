using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CheckEvenOrOdd
    {
        public void CheckEvenOrOddNum()
        {
            int N;
            Console.WriteLine("Enter a number to check whether it is even or odd");
            N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine(N + " is Even");
            }
            else
            {
                Console.WriteLine(N + " is Odd");
            }
        }
    }
}
