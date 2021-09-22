using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CheckLeapYear
    {
        public void CheckLeapYr()
        {
            int n;
            Console.WriteLine("Enter a four digit positive number");
            n = Convert.ToInt32(Console.ReadLine());
            if(n >= 1000 && n <= 9999)
            {
                if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
                {
                    Console.WriteLine("given number " + n + " is a leap year");
                }
                else
                {
                    Console.WriteLine("given number " + n + " is not leap year");
                }
            }
            else
            {
                Console.WriteLine("enter a valid year");
            }
        }
    }
}
