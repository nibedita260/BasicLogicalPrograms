using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CheckEvenOrOdd
    {
        public void CheckEvenOrOddNum()
        {
            int n;
            Console.WriteLine("Enter a number to check whether it is even or odd");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even");
            }
            else
            {
                Console.WriteLine(n + " is Odd");
            }
        }
    }
}