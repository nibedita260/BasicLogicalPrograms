using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PowerOfTwo
    {
        public void PowerOfTwoTable() {
            UInt64 N;// since 2^31 to not overflows an int
            Console.WriteLine("Enter number to print power of two of that number");
            N = Convert.ToUInt64(Console.ReadLine());
                for (int i = 1; i <= Math.Pow(2, N); i++)
                {
                    Console.WriteLine("The table of the powers of 2:" + Math.Pow(2,i));
                }
        }
    }
}
