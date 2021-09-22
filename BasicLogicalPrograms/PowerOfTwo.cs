using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PowerOfTwo
    {
        public void PowerOfTwoTable() {
            int n;// since 2^31 overflows an int,take 0<=n<31
            Console.WriteLine("Enter number to print till power of two of that number");
            n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("The table of the powers of 2:" + Math.Pow(2,i));
                }
        }
    }
}
