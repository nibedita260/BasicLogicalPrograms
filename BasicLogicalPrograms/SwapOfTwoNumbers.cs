using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class SwapOfTwoNumbers
    {
        public int SwapOfNum(int a,int b)
        {
            Console.WriteLine("Before Swapping a=" + a + ",b=" + b);//3,4
            a +=b;//7
            b -= b;//7-4=3
            a -= b;//7-3=4
            Console.WriteLine("After Swapping a=" + a + ",b=" + b);
            return a;
        }
    }
}
