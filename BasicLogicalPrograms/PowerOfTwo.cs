using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PowerOfTwo
    {
        public void PowerOfTwoTable() {
            int N;
            int result=0;
            Console.WriteLine("Enter number to print power of two of that number");
            N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= (2^N); i++)
            {
                result = 2 * i;
                Console.WriteLine("The table of the powers of 2:" + result);
            }
            
        }
    }
}
