using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PrimeFactor
    {
        public void PrintPrimeFactors()
        {
            int n;
            Console.WriteLine("Enter a number to print prime factors");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors of the given number are: ");
            for (int i = 2; i*i<=n; i++)//i*i<=n
            {
                if (n % i == 0 && (i == 2 || i % 2 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
