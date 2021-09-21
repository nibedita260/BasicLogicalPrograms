using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CheckLeapYear
    {
        public void CheckLeapYr()
        {
            int N;
            Console.WriteLine("Enter a four digit positive number");
            N = Convert.ToInt32(Console.ReadLine());
            if(N >= 1000 && N <= 9999)
            {
                if ((N % 4 == 0 && N % 100 != 0) || (N % 400 == 0))
                {
                    Console.WriteLine("given number " + N + " is a leap year");
                }
                else
                {
                    Console.WriteLine("given number " + N + " is not leap year");
                }
            }
            else
            {
                Console.WriteLine("enter a valid year");
            }
        }
    }
}
