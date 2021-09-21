using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class LargestAmongThreeNumbers
    {
        public int LargestNumber(int a, int b,int c)
        {
            int largest=0;
            Console.WriteLine("The numbers you entered are:" + a + "," + b + "," + c);
            if(a>b && a > c)
            {
                largest = a;
            }
            if (b > a && b > c)
            {
                largest = b;
            }
            if (c > a && c > b)
            {
                largest = c;
            }
            Console.WriteLine("The largest number among ["+a+","+b+","+c+"] is :"+largest);
            return a;
        }
    }
}
