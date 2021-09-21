using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class PrimeFactor
    {
        public void PrintPrimeFactors()
        {
            int N;
            Console.WriteLine("Enter a number to print prime factors");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors of the given number are: ");
            for (int i = 2; i*i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
